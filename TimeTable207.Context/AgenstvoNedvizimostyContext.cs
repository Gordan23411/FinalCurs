
using AgenstvoNedvizimosty.Context.Contracts;
using AgenstvoNedvizimosty.Context.Contracts.Models;

namespace AgenstvoNedvizimosty.Context
{
    public class AgenstvoNedvizimostyContext : IAgenstvoNedvizimostyContext
    {

        private ICollection<Putevka> putevkas;
        private ICollection<PutTargetItem> putTargetItems;
        private ICollection<Target> targets;
        private ICollection<Turist> turists;
        private ICollection<TurOper> turOpers;

        public AgenstvoNedvizimostyContext()
        {
            putevkas = new HashSet<Putevka>();
            putTargetItems = new HashSet<PutTargetItem>();
            targets = new HashSet<Target>();
            turists = new HashSet<Turist>();
            turOpers = new HashSet<TurOper>();
            Seed();
        }

        public ICollection<Putevka> Putevkas => putevkas ;

        public ICollection<PutTargetItem> PutTargetItems => putTargetItems;

        public ICollection<Target> Targets => targets;

        public ICollection<Turist> Turists => turists;

        public ICollection<TurOper> TurOpers => turOpers;

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        private void Seed()
        {
            turists.Add(new Turist
            {
                Id = Guid.NewGuid(),
                NFO = "Криуленко Тимур Андреевич",
                SeriesAndNomerPass = "26262521 7675",
                email = "timur.kriulenko.10@mail.ru",
                PhoneNumber = "+79817088150",
            });

            putTargetItems.Add(new PutTargetItem
            {
                Id = Guid.NewGuid(),
                TargetID = Guid.NewGuid(),
                Count = 32323,
                Summ = 123,
            });

            targets.Add(new Target
            {
                Id = Guid.NewGuid(),
                namePut = "Моё солнышко",
                KudaAdress = "Саратов",
                PriseHuman = 3000,
            });

            turists.Add(new Turist
            {
                Id = Guid.NewGuid(),
                NFO = "Криуленко Тимур Андреевич",
                SeriesAndNomerPass = "26262521 7655",
                email = "timur.kriulenko.10@mail.ru",
                PhoneNumber = "+79817088150",
            });

            turOpers.Add(new TurOper
            {
                Id = Guid.NewGuid(),
                NameOper = "Николай Николай Николай",
                UrAdress = "Туристкая 18",
                FactAdress = "Туристкая 19",
                INN = "499449492312",
                OKPO = "47575675",
            });
            putevkas.Add(new Putevka
            {
                Id = Guid.NewGuid(),
                
            });
        }
    }
}