using AnarJson.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnarJson.DAL;

namespace AnarJson
{
    public partial class Form1 : Form
    {
        AnarContext context;
        RestClient client;

        public Form1()
        {
            InitializeComponent();
            context = new AnarContext();
            client = new RestClient("https://jsonplaceholder.typicode.com");
            //GroupJsonParser();
            GetTodos();

            DisplayUserTodos();
        }

        public void GroupJsonParser()
        {
            List<User> users = new List<User>();

            var request = new RestRequest("users");

            IRestResponse response = client.Execute(request);

            users = JsonConvert.DeserializeObject<List<User>>(response.Content);


            foreach (User user in users)
            {
                context.Addresses.Add(user.address);

                context.Companies.Add(user.company);

                //user.AddressId = user.address.Id;
                //user.CompanyId = user.company.Id;
                context.Users.Add(user);
                context.SaveChanges();
            }

        }

        public void GetTodos()
        {
            List<Todo> todos = new List<Todo>();

            var request = new RestRequest("todos");

            IRestResponse response = client.Execute(request);

            todos = JsonConvert.DeserializeObject<List<Todo>>(response.Content);


            foreach (Todo todo in todos)
            {
                context.Todos.Add(todo);
                context.SaveChanges();
            }

        }

        public void DisplayUserTodos()
        {
            User user = context.Users.Include("Address").Include("Company").FirstOrDefault(u => u.id == 9);
            MessageBox.Show(user.company.name);
            List<Todo> todos = context.Todos.Where(t => t.UserId == 1).ToList();
            foreach (var item in todos)
            {
                richTextBox1.Text += item.Title + "\n";
            }
        }


    }
}
