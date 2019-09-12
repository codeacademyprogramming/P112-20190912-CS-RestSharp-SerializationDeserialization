using ProjectCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using RestSharp;
using System.Net;

namespace ProjectCodeFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Demo();
            UlviJsonParser();
        }

        public void Demo()
        {
            Manufacturer manufacturer = new Manufacturer
            {
                Name = "Mercedes"
            };

            Car car = new Car();
            car.Manufacturer = manufacturer;
            car.Model = "S600";
            car.Year = 2019;
            car.Engine = 6.0f;

            string carJson = JsonConvert.SerializeObject(car);

            rtxtJson.Text = carJson;
        }


        public void UlviJsonParser()
        {
            List<User> users = new List<User>();

            try
            {
                var client = new RestClient("https://turbo.az");
                var request = new RestRequest("autos/3447168-kia-optima", Method.GET);

                IRestResponse response = client.Execute(request);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    users = JsonConvert.DeserializeObject<List<User>>(response.Content);
                }


                foreach (User item in users)
                {
                    rtxtJson.Text += item.fullname + "\n";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
