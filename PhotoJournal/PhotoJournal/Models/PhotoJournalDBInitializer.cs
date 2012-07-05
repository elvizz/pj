using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PhotoJournal.Models
{
    public class PhotoJournalDBInitializer: DropCreateDatabaseIfModelChanges<PJContext>
    {
        protected override void Seed(PJContext context)
        {
            var lenta = new List<PhotoLenta>
                            {
                                new PhotoLenta {Title = "Кит", Name = "9nKZ70UdGrU.jpg", DateTime = DateTime.Now, Description = "Кит выпрыгивает из воды"},
                                new PhotoLenta {Title = "Кошка переносит котенка", Name = "13415143651436.jpg",
                                    DateTime = DateTime.Now, Description = "Нью-Йорк, 1925год. Движение приостановлено из-за кошки переносящей через дорогу котенка"},
                                new PhotoLenta {Title = "Куба", Name = "15645645373568.jpg", DateTime = DateTime.Now, Description = "Фейерверки на Кубе"},
                                new PhotoLenta {Title = "Сладкая вата", Name = "1331549008421915.jpeg", DateTime = DateTime.Now, Description = "Счастью нет границ."},
                                new PhotoLenta {Title = "Огонь и торнадо", Name = "152564576538476.jpg", DateTime = DateTime.Now, Description = "Огоень и торнадо"},
                                new PhotoLenta {Title = "Миграция скатов", Name = "1556425765786538.jpg", DateTime = DateTime.Now, Description = "Миграция золотистых скатов"},
                                new PhotoLenta {Title = "Красная армия", Name = "1425645765847698.jpg", DateTime = DateTime.Now, Description = "Парад"},
                                new PhotoLenta {Title = "Дети", Name = "FRROerb-Yn8.jpg", DateTime = DateTime.Now, Description = "Какие-то дети, старый снимок"},
                                new PhotoLenta {Title = "Али", Name = "KMxq3PR0tb4.jpg", DateTime = DateTime.Now, Description = "Али во время боя"},
                                new PhotoLenta {Title = "Конец войны", Name = "nA1bV_YvoAA.jpg", DateTime = DateTime.Now, Description = "Русский флаг над рейхстагом"},
                                new PhotoLenta {Title = "Ребенок и медведь", Name = "roEAI4d7ju8.jpg", DateTime = DateTime.Now, Description = "Друг детства"},
                                new PhotoLenta {Title = "Парашютист", Name = "Rxjf0R9prpQ.jpg", DateTime = DateTime.Now, Description = "Прыжок вниз"},
                                new PhotoLenta {Title = "Монашки", Name = "x_c9362c90.jpg", DateTime = DateTime.Now, Description = "Монашки любят отдохнуть"},
                                new PhotoLenta {Title = "Дети", Name = "x_e4b2848e.jpg", DateTime = DateTime.Now, Description = "Старший брат"},
                                new PhotoLenta {Title = "Строители Нью-Йорка", Name = "y_78c61fcd.jpg", DateTime = DateTime.Now, Description = "Нью-Йорк 1932 год, две бригады"},
                                new PhotoLenta {Title = "Девушки в бикини", Name = "zFBAXn7ceAY.jpg", DateTime = DateTime.Now, Description = "Девушек в бикини повязали копы"},
                            };
            lenta.ForEach(l=>context.PhotoLentas.Add(l));
            context.SaveChanges();
            
            base.Seed(context);
        }
    }
}