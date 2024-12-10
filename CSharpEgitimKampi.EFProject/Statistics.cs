using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi.EFProject
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        EgitimKampiEFTravelDbEntities db = new EgitimKampiEFTravelDbEntities();

        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            lblLocationCount.Text = db.Location.Count().ToString();
            lblSumCapacity.Text = db.Location.Sum(x => x.LocationCapacity).ToString();
            lblGuideCount.Text = db.Guide.Count().ToString();
            lblAvgCapacity.Text = db.Location.Average(x => (decimal?)x.LocationCapacity)?.ToString("0.00");
            lblAvgLocationPrice.Text = db.Location.Average(x => (decimal?)x.LocationPrice)?.ToString("0.00") + "₺";
            int lastConuntryId = db.Location.Max(x => x.LocationId);
            lblLastCountry.Text = db.Location.Where(x=>x.LocationId == lastConuntryId).Select(y => y.LocationCountry).FirstOrDefault();

            lblCappadociaLocationCapacity.Text = db.Location.Where(x => x.LocationCity == "Kapadokya").Select(y => y.LocationCapacity).FirstOrDefault().ToString();
            lblTurkiyeCapacityAvg.Text = db.Location.Where(x => x.LocationCountry == "Türkiye").Average(y => (decimal?)y.LocationCapacity)?.ToString("0.00");
            
            var romeGuideId = db.Location.Where(x => x.LocationCity == "Roma Tristik").Select(y => y.GuideId).FirstOrDefault();
            lblRomeGuideName.Text = db.Guide.Where(x => x.GuideId == romeGuideId).Select(y => y.GuideName + y.GuideSurname).FirstOrDefault().ToString();

            var maxCapacity = db.Location.Max(x => x.LocationCapacity);
            lblMaxCapacityLocation.Text = db.Location.Where(x => x.LocationCapacity == maxCapacity).Select(y => y.LocationCity).FirstOrDefault().ToString();

            var maxPrice = db.Location.Max(x => x.LocationPrice);
            lblMaxPriceLocation.Text = db.Location.Where(x => x.LocationPrice == maxPrice).Select(y => y.LocationCity).FirstOrDefault().ToString();

            var guideIdByAysegulCinar = db.Guide.Where(x => x.GuideName == "Ayşegül" && x.GuideSurname == "Çınar").Select(y => y.GuideId).FirstOrDefault();
            lblAysegulCınarLocationCount.Text = db.Location.Where(x => x.GuideId == guideIdByAysegulCinar).Count().ToString();
        }

        
    }
}
