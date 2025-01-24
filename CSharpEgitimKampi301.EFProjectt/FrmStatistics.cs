using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProjectt
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }
        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            
            lblLocationCount.Text = db.Location.Count().ToString();

            lblSumCapacity.Text = db.Location.Sum(x=> x.Capasity).ToString();

            lblGuideCount.Text = db.Guide.Count().ToString();

            lblAvgCapacity.Text = db.Location.Average(x=> x.Capasity).ToString();

            lblAvgLocationPrice.Text = db.Location.Average(x => x.Price).ToString() + " ₺";

            int lastCountryId = db.Location.Max(x => x.LocationId);
            lblLastCountryName.Text = db.Location.Where(x => x.LocationId == lastCountryId).Select(y=>y.Country).FirstOrDefault();

            lblCappadociaLocationCapacity.Text = db.Location.Where(x=>x.City=="Kapadokya").Select(y=>y.Capasity).FirstOrDefault().ToString();
            lblTurkiyeCapacityAvg.Text = db.Location.Where(x => x.Country == "Türkiye").Average(y => y.Capasity).ToString(); 

            var romeGuideId=db.Location.Where(x=>x.City=="Roma Turistik").Select(y=>y.GuideId).FirstOrDefault();
            lblRomeGuideName.Text=db.Guide.Where(x=>x.GuideId==romeGuideId).Select(y=>y.GuideName + " " + y.GuideSurname).FirstOrDefault().ToString();

            var maxCapacity= db.Location.Max(x=>x.Capasity);
            lblMaxCapacityLocation.Text=db.Location.Where(x=>x.Capasity==maxCapacity).Select(y=>y.City).FirstOrDefault().ToString();

            var maxPrice = db.Location.Max(x => x.Price);
            lblMaxPriceLocation.Text= db.Location.Where(x=> x.Price == maxPrice).Select(y=>y.City).FirstOrDefault().ToString();

            var guideIdByNameAysegulCinar = db.Guide.Where(x => x.GuideName == "Ayşegül" && x.GuideSurname == "Çınar").Select(y => y.GuideId).FirstOrDefault();
            lblAysegulCinarLocationCount.Text = db.Location.Where(x => x.GuideId == guideIdByNameAysegulCinar).Count().ToString();

        }

        private void lblAvgCapacity_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lblRomeGuideName_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void lblAvgCapacity_Click_1(object sender, EventArgs e)
        {

        }
    }
}
