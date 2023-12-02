using Aspose.Imaging;
using Aspose.Svg;
using Aspose.Imaging.FileFormats.Svg;
using Aspose.Imaging.ImageOptions;

//using Aspose.Svg.Rendering;
//using Aspose.Svg.Rendering.Image;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.ComTypes;
//using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using Aspose.Svg.Rendering;
using Aspose.Svg.Rendering.Image;


namespace Aplicativo_Previsão_do_Tempo
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void SearchGoeIP()
        {
            string url = "https://api.hgbrasil.com/geoip?key=eb321b19&address=remote&precision=false";
            using (HttpClient clientIP = new HttpClient())
            {
                var response = clientIP.GetAsync(url).Result;
                if (response.IsSuccessStatusCode)
                {
                    var resultado = response.Content.ReadAsStringAsync().Result;
                    GeoIP geo = JsonConvert.DeserializeObject<GeoIP>(resultado);
                    //geo.Results.City2;

                    SearchClimate(geo.Results.City, geo.Results.RegionCode);
                    lb_ip.Text = geo.Results.Address;
                    lb_type.Text = geo.Results.Type;
                    lb_region.Text = geo.Results.Region;
                    tb_cidade.Text = geo.Results.City;
                    cb_estado.Text = geo.Results.RegionCode;
                }
            }

        }


        private void SearchClimate(string cidade, string estado)
        {
            string url = "https://api.hgbrasil.com/weather?key=eb321b19&city_name=" + cidade+","+estado;

            using (HttpClient client = new HttpClient())
            {
                var response = client.GetAsync(url).Result;
                if (response.IsSuccessStatusCode)
                {
                    var resultado = response.Content.ReadAsStringAsync().Result;
                    Weather previsao = JsonConvert.DeserializeObject<Weather>(resultado);
                    //Forecast forecast = JsonConvert.DeserializeObject<Forecast>(resultado);
                        
                    pb_contionalslug.ImageLocation = @"D:\ProjetosemCS\ProjetoCS\Aplicativo Previsão do Tempo\img\"+ previsao.Results.ConditionSlug + ".png";
                    pb_moonphase.ImageLocation = "https://assets.hgbrasil.com/weather/icons/moon/"+previsao.Results.MoonPhase+".png";
                    lb_data.Text = previsao.Results.Date;
                    lb_clock.Text = previsao.Results.Time;
                    lb_temp.Text = Convert.ToString(previsao.Results.Temp)+" ºC";
                    lb_description.Text = previsao.Results.Description;
                    lb_windspeed.Text = previsao.Results.WindSpeedy;
                    lb_rain.Text = Convert.ToString(previsao.Results.Rain)+" mm";
                    lb_timezone.Text = previsao.Results.Timezone;
                    lb_sunrise.Text =   previsao.Results.Sunrise;
                    lb_sunset.Text = previsao.Results.Sunset;
                    // lb_conditionslug.Text = previsao.Results.ConditionSlug;
                    //pb_contionalslug.ImageLocation = "https://assets.hgbrasil.com/weather/icons/conditions/cloudly_day.svg";
                    //lb_debug.Text = Convert.ToString(previsao.Results.Forecast[2].Rain);


                  
                   
                }
                else
                {
                    //lb_conditionslug.Text = Convert.ToString(response.StatusCode);
                }
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            SearchClimate(tb_cidade.Text,cb_estado.Text);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bt_ipgeo_Click(object sender, EventArgs e)
        {
            SearchGoeIP();
            lb_ip.Visible = true;
            lb_ip1.Visible = true;
            lb_region.Visible = true;
            lb_region1.Visible = true;
            lb_type.Visible = true;
            lb_type1.Visible = true; 

        }
    }
}
