using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Yad2.EFRepositories;
using Yad2.Model.Entities;
using Yad2.Model.Entities.BaseEntities;
using Infrastructure.Security.Model;
using Infrastructure.Security.Interfaces;

namespace Yad2.Web.Mvc.UI.Infrastructure
{
    public class GenerateBaseDB
    {
        
        public static void GenerateInitialValuesIntoDB()
        {


            GenerateUsersAndGroups();

            EFContext.Get().SaveChanges();

            GenerateSellers();

            EFContext.Get().SaveChanges();

            GenerateCategories();

            EFContext.Get().SaveChanges();

            GenerateVehicleManufacturerAndModels();

            EFContext.Get().SaveChanges();

            GenerateRegions();

            EFContext.Get().SaveChanges();

            GenerateCarsGearTypes();

            EFContext.Get().SaveChanges();

            GeneratePrivateCars();

            EFContext.Get().SaveChanges();

            GenerateMotorcycles();

            EFContext.Get().SaveChanges();

            GenerateColors();

            EFContext.Get().SaveChanges();

            GeneratePrivateScooter();
            EFContext.Get().SaveChanges();
           


            GenerateCommercial();
            EFContext.Get().SaveChanges();

            GeneratePrivateJeeps();
            EFContext.Get().SaveChanges();

            GenerateSecondHandStates();
            EFContext.Get().SaveChanges();

            GenerateSecondHandTypes();
            EFContext.Get().SaveChanges();

            GenerateSecondHandItems();
            EFContext.Get().SaveChanges();
        }

             private static void GenerateSecondHandStates()
        {
            var secondHandStates = new SecondHandState[] { 
                            new SecondHandState() { Name = "חדש באריזה" },
                            new SecondHandState() { Name = "כמו חדש" },
                            new SecondHandState() { Name = "משומש" },
                            new SecondHandState() { Name = "דרוש תיקון/שיפוץ" },
                            new SecondHandState() { Name = "לא רלוונטי" }
            };

            EFContext.Get().SecondHandStates.AddRange(secondHandStates);
        }

        private static void GenerateSecondHandTypes()
        {
            
           

var main1 =  new SecondHandType() { Name = "גראג' סייל", HasManufacturer = false };
EFContext.Get().SecondHandTypes.Add(main1);
EFContext.Get().SaveChanges();

// sub types of גראג' סייל:

EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "כללי", ParentTypeId = main1.Id , HasManufacturer = false });


var main2 =  new SecondHandType() { Name = "למסירה - הכל בחינם", HasManufacturer = false };
EFContext.Get().SecondHandTypes.Add(main2);
EFContext.Get().SaveChanges();

// sub types of למסירה - הכל בחינם:

EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אומנות", ParentTypeId = main2.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אופניים", ParentTypeId = main2.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אספנות", ParentTypeId = main2.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ביגוד", ParentTypeId = main2.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "יודאיקה", ParentTypeId = main2.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "כלי נגינה", ParentTypeId = main2.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "כלי עבודה", ParentTypeId = main2.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "כלים סניטריים", ParentTypeId = main2.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "לבית", ParentTypeId = main2.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "לגינה", ParentTypeId = main2.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "לתינוק ולילד", ParentTypeId = main2.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מוסיקה וסרטים", ParentTypeId = main2.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מוצרי חשמל", ParentTypeId = main2.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מחשבים וציוד נלווה", ParentTypeId = main2.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מנויים וכרטיסים", ParentTypeId = main2.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "סטריאו", ParentTypeId = main2.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "סלולרי", ParentTypeId = main2.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ספורט", ParentTypeId = main2.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ספרות ומאמרים", ParentTypeId = main2.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ציוד לעסקים", ParentTypeId = main2.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ציוד לתעשייה", ParentTypeId = main2.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ציוד סעודי\\ רפואי", ParentTypeId = main2.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "צילום", ParentTypeId = main2.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "קוסמטיקה", ParentTypeId = main2.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ריהוט", ParentTypeId = main2.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "תכשיטים", ParentTypeId = main2.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "תקשורת", ParentTypeId = main2.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אחר", ParentTypeId = main2.Id , HasManufacturer = false });


var main3 =  new SecondHandType() { Name = "אומנות", HasManufacturer = false };
EFContext.Get().SecondHandTypes.Add(main3);
EFContext.Get().SaveChanges();

// sub types of אומנות:

EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "פוסטרים", ParentTypeId = main3.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "חפצי נוי", ParentTypeId = main3.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "כדים וקערות", ParentTypeId = main3.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "פסלים", ParentTypeId = main3.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "פוחלצים", ParentTypeId = main3.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ציוד לאומנות", ParentTypeId = main3.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ציורים", ParentTypeId = main3.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "קריסטלים", ParentTypeId = main3.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "תמונות", ParentTypeId = main3.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אחר", ParentTypeId = main3.Id , HasManufacturer = false });


var main4 =  new SecondHandType() { Name = "אופניים", HasManufacturer = false };
EFContext.Get().SecondHandTypes.Add(main4);
EFContext.Get().SaveChanges();

// sub types of אופניים:

EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אביזרים", ParentTypeId = main4.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "הרים זנב קשיח", ParentTypeId = main4.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "הרים שיכוך מלא", ParentTypeId = main4.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "הרים 29'", ParentTypeId = main4.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "סינגלספיד", ParentTypeId = main4.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אופני כביש", ParentTypeId = main4.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אופניים חשמליים", ParentTypeId = main4.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "נג'ש וטריאתלון", ParentTypeId = main4.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אופני - ילדים", ParentTypeId = main4.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אופני נשים", ParentTypeId = main4.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אופני עיר", ParentTypeId = main4.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אופני פעלולים / BMX", ParentTypeId = main4.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אופניים מתקפלים", ParentTypeId = main4.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "תלת אופן", ParentTypeId = main4.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אופניים מיוחדים", ParentTypeId = main4.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אחר", ParentTypeId = main4.Id , HasManufacturer = false });


var main5 =  new SecondHandType() { Name = "אספנות", HasManufacturer = false };
EFContext.Get().SecondHandTypes.Add(main5);
EFContext.Get().SaveChanges();

// sub types of אספנות:

EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אוספים שונים", ParentTypeId = main5.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "בובות", ParentTypeId = main5.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "בולים,מעטפות וגלויות", ParentTypeId = main5.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "דגמי מכוניות", ParentTypeId = main5.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "חפצי נוי", ParentTypeId = main5.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "טלפונים", ParentTypeId = main5.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "יינות", ParentTypeId = main5.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "כלי נגינה", ParentTypeId = main5.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "כלים", ParentTypeId = main5.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "כרטיסי חיוג טלכרד", ParentTypeId = main5.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "לבית", ParentTypeId = main5.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מוצרי ילדות", ParentTypeId = main5.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מוצרי קוקה קולה", ParentTypeId = main5.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מזוודות וקופסאות", ParentTypeId = main5.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מטבעות ושטרות", ParentTypeId = main5.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מכונות כתיבה", ParentTypeId = main5.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מכונות תפירה", ParentTypeId = main5.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מצלמות", ParentTypeId = main5.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "עטים", ParentTypeId = main5.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "עיתונים ומגזינים", ParentTypeId = main5.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "פטיפונים וטייפיים", ParentTypeId = main5.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "פריטים ארכיאולוגים", ParentTypeId = main5.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "קומיקס", ParentTypeId = main5.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "רדיו", ParentTypeId = main5.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ריהוט", ParentTypeId = main5.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "שעונים", ParentTypeId = main5.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "תמונות", ParentTypeId = main5.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "תקליטים\\ דיסקים", ParentTypeId = main5.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אחר", ParentTypeId = main5.Id , HasManufacturer = false });


var main6 =  new SecondHandType() { Name = "ביגוד ואביזרים", HasManufacturer = false };
EFContext.Get().SecondHandTypes.Add(main6);
EFContext.Get().SaveChanges();

// sub types of ביגוד ואביזרים:

EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ארנקים", ParentTypeId = main6.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ביגוד ונעליים מקצועיות", ParentTypeId = main6.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "בגדי הריון", ParentTypeId = main6.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "בגדי ים", ParentTypeId = main6.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "בגדי עבודה", ParentTypeId = main6.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "בגדי רכיבת סוסים", ParentTypeId = main6.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "בדים", ParentTypeId = main6.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ג'ינסים ומכנסיים", ParentTypeId = main6.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "הלבשה תחתונה", ParentTypeId = main6.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "חגורות", ParentTypeId = main6.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "חולצות", ParentTypeId = main6.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "חליפות חתן", ParentTypeId = main6.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "חליפות לגבר", ParentTypeId = main6.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "חצאיות", ParentTypeId = main6.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "כובעים/מגבעות", ParentTypeId = main6.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מעילים וג'קטים", ParentTypeId = main6.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אקססוריז לנשים", ParentTypeId = main6.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אקססוריז לגברים", ParentTypeId = main6.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אקססוריז לכלות", ParentTypeId = main6.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "משקפי שמש", ParentTypeId = main6.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "משקפי ראייה", ParentTypeId = main6.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "נעליים", ParentTypeId = main6.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "סוודרים", ParentTypeId = main6.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "פאות", ParentTypeId = main6.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "קולבים", ParentTypeId = main6.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "שמלות וחליפות", ParentTypeId = main6.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "שמלות כלה", ParentTypeId = main6.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "שמלות כלה - השכרה", ParentTypeId = main6.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "שמלות שושבינה", ParentTypeId = main6.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "שמלות ערב", ParentTypeId = main6.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "שמלות ערב - השכרה", ParentTypeId = main6.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "תיקים", ParentTypeId = main6.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "תחפושות ואביזרים", ParentTypeId = main6.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אחר", ParentTypeId = main6.Id , HasManufacturer = false });


var main7 =  new SecondHandType() { Name = "יודאיקה", HasManufacturer = false };
EFContext.Get().SecondHandTypes.Add(main7);
EFContext.Get().SaveChanges();

// sub types of יודאיקה:

EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אומנות", ParentTypeId = main7.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "חנוכיות", ParentTypeId = main7.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "כלי כסף", ParentTypeId = main7.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ספרים ומאמרים", ParentTypeId = main7.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ציוד לבית כנסת", ParentTypeId = main7.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "תשמישי קדושה", ParentTypeId = main7.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אחר", ParentTypeId = main7.Id , HasManufacturer = false });


var main8 =  new SecondHandType() { Name = "כלי נגינה", HasManufacturer = false };
EFContext.Get().SecondHandTypes.Add(main8);
EFContext.Get().SaveChanges();

// sub types of כלי נגינה:

EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "כלי מיתר", ParentTypeId = main8.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "כלי הקשה ותופים", ParentTypeId = main8.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מגבר", ParentTypeId = main8.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אורגן", ParentTypeId = main8.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "פסנתר", ParentTypeId = main8.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "כלי נשיפה", ParentTypeId = main8.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "קלידים", ParentTypeId = main8.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ספרי תווים", ParentTypeId = main8.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אקורדיון", ParentTypeId = main8.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אביזרים נלווים", ParentTypeId = main8.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אחר", ParentTypeId = main8.Id , HasManufacturer = false });


var main9 =  new SecondHandType() { Name = "כלי נשק", HasManufacturer = false };
EFContext.Get().SecondHandTypes.Add(main9);
EFContext.Get().SaveChanges();

// sub types of כלי נשק:

EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "CZ", ParentTypeId = main9.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "smith & Wesson", ParentTypeId = main9.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אקדח FN", ParentTypeId = main9.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אקדח אויר", ParentTypeId = main9.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "בול", ParentTypeId = main9.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ברטה", ParentTypeId = main9.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "גלוק", ParentTypeId = main9.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "הגנה עצמית", ParentTypeId = main9.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "וולטר", ParentTypeId = main9.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "זיג זאוור", ParentTypeId = main9.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "טנפוליו", ParentTypeId = main9.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "יריחו", ParentTypeId = main9.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "נשק קר", ParentTypeId = main9.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "קולט", ParentTypeId = main9.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "רובה אויר", ParentTypeId = main9.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אביזרים", ParentTypeId = main9.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אחר", ParentTypeId = main9.Id , HasManufacturer = false });


var main10 =  new SecondHandType() { Name = "כלי עבודה", HasManufacturer = false };
EFContext.Get().SecondHandTypes.Add(main10);
EFContext.Get().SaveChanges();

// sub types of כלי עבודה:

EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "חומרי עבודה", ParentTypeId = main10.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "כלי עבודה", ParentTypeId = main10.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "כלי עבודה לגינה", ParentTypeId = main10.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "כלים לנגרות", ParentTypeId = main10.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "כלים לעבודת מכונאות", ParentTypeId = main10.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "כלים לשרברבות", ParentTypeId = main10.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "גנרטורים", ParentTypeId = main10.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אחר", ParentTypeId = main10.Id , HasManufacturer = false });


var main11 =  new SecondHandType() { Name = "כלים סניטריים", HasManufacturer = false };
EFContext.Get().SecondHandTypes.Add(main11);
EFContext.Get().SaveChanges();

// sub types of כלים סניטריים:

EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ארונות מטבח", ParentTypeId = main11.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ברזים", ParentTypeId = main11.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ג'קוזי", ParentTypeId = main11.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "כיורים", ParentTypeId = main11.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "לאמבטיה ולשירותים", ParentTypeId = main11.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מקלחונים", ParentTypeId = main11.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "סאונה", ParentTypeId = main11.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "שיש", ParentTypeId = main11.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אחר", ParentTypeId = main11.Id , HasManufacturer = false });


var main12 =  new SecondHandType() { Name = "לבית", HasManufacturer = false };
EFContext.Get().SecondHandTypes.Add(main12);
EFContext.Get().SaveChanges();

// sub types of לבית:

EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ארגזי אחסון", ParentTypeId = main12.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "בלוני גז", ParentTypeId = main12.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ברזים", ParentTypeId = main12.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "גראג' סייל", ParentTypeId = main12.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "דוד חימום", ParentTypeId = main12.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "הרחקת מזיקים", ParentTypeId = main12.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "וילונות", ParentTypeId = main12.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "חימום על גז", ParentTypeId = main12.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "חימום על סולר", ParentTypeId = main12.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "חלונות", ParentTypeId = main12.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "חפצי נוי", ParentTypeId = main12.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ידיות", ParentTypeId = main12.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "כיורים", ParentTypeId = main12.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "כלי אוכל", ParentTypeId = main12.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "כלי מיטה", ParentTypeId = main12.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "כלי עבודה", ParentTypeId = main12.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "כספת", ParentTypeId = main12.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "כריות נוי", ParentTypeId = main12.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "לאמבטיה ולשירותים", ParentTypeId = main12.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "למטבח", ParentTypeId = main12.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מדרגות מתקפלות", ParentTypeId = main12.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מטהרי אוויר לבית", ParentTypeId = main12.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מכשירי סודה", ParentTypeId = main12.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מנגל", ParentTypeId = main12.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מקלחונים", ParentTypeId = main12.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "משקל", ParentTypeId = main12.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מתקן ייבוש כלים", ParentTypeId = main12.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מתקן עיתונים", ParentTypeId = main12.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מתקני / מטהרי מים", ParentTypeId = main12.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "סולמות", ParentTypeId = main12.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "סורגים", ParentTypeId = main12.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "סכו'ם", ParentTypeId = main12.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "עגלת קניות", ParentTypeId = main12.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "פחי אשפה", ParentTypeId = main12.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "פרקטים", ParentTypeId = main12.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "קמין", ParentTypeId = main12.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "קרש גיהוץ", ParentTypeId = main12.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ריצוף וחיפוי", ParentTypeId = main12.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "תמונות", ParentTypeId = main12.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "תנור נפט", ParentTypeId = main12.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אחר", ParentTypeId = main12.Id , HasManufacturer = false });


var main13 =  new SecondHandType() { Name = "לגינה", HasManufacturer = false };
EFContext.Get().SecondHandTypes.Add(main13);
EFContext.Get().SaveChanges();

// sub types of לגינה:

EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ברזנטים", ParentTypeId = main13.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "בריכה", ParentTypeId = main13.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "חפצי נוי", ParentTypeId = main13.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "כלי עבודה", ParentTypeId = main13.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מחסן", ParentTypeId = main13.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מכסחת דשא", ParentTypeId = main13.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ממטרות ומערכות השקיה", ParentTypeId = main13.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מנגל", ParentTypeId = main13.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "נדנדות וערסל", ParentTypeId = main13.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "סוכות", ParentTypeId = main13.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "עצי זית עתיקים", ParentTypeId = main13.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "עצים ועציצים", ParentTypeId = main13.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "פרגולות", ParentTypeId = main13.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "צמחיה מלאכותית", ParentTypeId = main13.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ריהוט לגינה", ParentTypeId = main13.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "תאורת גן", ParentTypeId = main13.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אחר", ParentTypeId = main13.Id , HasManufacturer = false });


var main14 =  new SecondHandType() { Name = "למטייל ולמתגייס", HasManufacturer = false };
EFContext.Get().SecondHandTypes.Add(main14);
EFContext.Get().SaveChanges();

// sub types of למטייל ולמתגייס:

EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אוהלים", ParentTypeId = main14.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אולרים וסכינים", ParentTypeId = main14.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ביגוד למטייל", ParentTypeId = main14.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "גזיה", ParentTypeId = main14.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "גלאי מתכות", ParentTypeId = main14.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "חרמונית", ParentTypeId = main14.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "כלי אוכל ובישול", ParentTypeId = main14.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מזוודות ותיקים", ParentTypeId = main14.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מחצלת", ParentTypeId = main14.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מצפנים", ParentTypeId = main14.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "משקפת \\ טלסקופ", ParentTypeId = main14.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "נעלי טרקים וסנדלים", ParentTypeId = main14.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ספרים ומפות", ParentTypeId = main14.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "פנסים", ParentTypeId = main14.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "צידניות", ParentTypeId = main14.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "קמפינג- כסאות ושולחנות", ParentTypeId = main14.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "שק שינה ומזרנים", ParentTypeId = main14.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "תרמילים", ParentTypeId = main14.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אחר", ParentTypeId = main14.Id , HasManufacturer = false });


var main15 =  new SecondHandType() { Name = "לתינוק ולילד", HasManufacturer = false };
EFContext.Get().SecondHandTypes.Add(main15);
EFContext.Get().SaveChanges();

// sub types of לתינוק ולילד:

EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אביזרי בטיחות", ParentTypeId = main15.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אביזרים ללידה ולהנקה", ParentTypeId = main15.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אוניברסיטה", ParentTypeId = main15.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אופני ילדים", ParentTypeId = main15.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אמבטיה\\ כלי אמבטיה", ParentTypeId = main15.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ביגוד והנעלה", ParentTypeId = main15.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "בייביסנס ומוניטורים", ParentTypeId = main15.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "הופעות לילדים", ParentTypeId = main15.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "הליכונים ובימבות", ParentTypeId = main15.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "טרמפולינה", ParentTypeId = main15.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "כורסת הנקה", ParentTypeId = main15.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "כלי אוכל", ParentTypeId = main15.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "כלי מיטה", ParentTypeId = main15.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "כסא לאוכל", ParentTypeId = main15.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "כסא לרכב", ParentTypeId = main15.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מובייל", ParentTypeId = main15.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מיטות ולולים", ParentTypeId = main15.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מכשיר אדים", ParentTypeId = main15.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ממונעים לילדים", ParentTypeId = main15.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מנשאים", ParentTypeId = main15.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "משחקים וצעצועים", ParentTypeId = main15.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מתקני גי'מבורי", ParentTypeId = main15.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "נדנדה", ParentTypeId = main15.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "סלקל", ParentTypeId = main15.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ספרי ילדים", ParentTypeId = main15.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "עגלות ועגלות טיול", ParentTypeId = main15.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "פורים", ParentTypeId = main15.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ציורים ותמונות", ParentTypeId = main15.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "קישוטים ואביזרים", ParentTypeId = main15.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "קלטות ו-DVD", ParentTypeId = main15.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "שידות החתלה / שידות", ParentTypeId = main15.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "תיקים", ParentTypeId = main15.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אחר", ParentTypeId = main15.Id , HasManufacturer = false });


var main16 =  new SecondHandType() { Name = "מבנים ניידים", HasManufacturer = false };
EFContext.Get().SecondHandTypes.Add(main16);
EFContext.Get().SaveChanges();

// sub types of מבנים ניידים:

EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "צימר", ParentTypeId = main16.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "קראוון", ParentTypeId = main16.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "שירותים ניידים", ParentTypeId = main16.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אחר", ParentTypeId = main16.Id , HasManufacturer = false });


var main17 =  new SecondHandType() { Name = "מוסיקה וסרטים", HasManufacturer = false };
EFContext.Get().SecondHandTypes.Add(main17);
EFContext.Get().SaveChanges();

// sub types of מוסיקה וסרטים:

EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "CD's", ParentTypeId = main17.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "DVD", ParentTypeId = main17.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "וידאו", ParentTypeId = main17.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "קלטות", ParentTypeId = main17.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "תקליטים", ParentTypeId = main17.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אחר", ParentTypeId = main17.Id , HasManufacturer = false });


var main18 =  new SecondHandType() { Name = "מוצרי Apple", HasManufacturer = false };
EFContext.Get().SecondHandTypes.Add(main18);
EFContext.Get().SaveChanges();

// sub types of מוצרי Apple:

EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ipod", ParentTypeId = main18.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מחשבים וציוד נילווה", ParentTypeId = main18.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "סלולרי", ParentTypeId = main18.Id , HasManufacturer = false });


var main19 =  new SecondHandType() { Name = "מוצרי טבק ואלכוהול", HasManufacturer = false };
EFContext.Get().SecondHandTypes.Add(main19);
EFContext.Get().SaveChanges();

// sub types of מוצרי טבק ואלכוהול:

EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אלכוהול", ParentTypeId = main19.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "טבק", ParentTypeId = main19.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מצתים", ParentTypeId = main19.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מקטרת", ParentTypeId = main19.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "נרגילה", ParentTypeId = main19.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "סיגריות", ParentTypeId = main19.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "סיגרייה אלקטרונית", ParentTypeId = main19.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "סיגרים", ParentTypeId = main19.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אחר", ParentTypeId = main19.Id , HasManufacturer = false });


var main20 =  new SecondHandType() { Name = "מוצרי-חשמל", HasManufacturer = false };
EFContext.Get().SecondHandTypes.Add(main20);
EFContext.Get().SaveChanges();

// sub types of מוצרי-חשמל:

EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "DVD", ParentTypeId = main20.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אופה לחם", ParentTypeId = main20.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "בלנדר ומיקסר", ParentTypeId = main20.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "וידאו", ParentTypeId = main20.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "זרוע לטלוויזיה", ParentTypeId = main20.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "טוחן אשפה", ParentTypeId = main20.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "טוסטר", ParentTypeId = main20.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "טוסטר אובן", ParentTypeId = main20.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "טלויזיה", ParentTypeId = main20.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "טלפונים ואביזרים", ParentTypeId = main20.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "כיריים", ParentTypeId = main20.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מאוורר", ParentTypeId = main20.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מגהץ", ParentTypeId = main20.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מדיח כלים", ParentTypeId = main20.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מזגן", ParentTypeId = main20.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מחברים וכבלים", ParentTypeId = main20.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מטחנת בשר", ParentTypeId = main20.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מטחנת קפה", ParentTypeId = main20.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מטען לסוללות", ParentTypeId = main20.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מיחם לשבת", ParentTypeId = main20.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מייבש כביסה", ParentTypeId = main20.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מיקרוגל", ParentTypeId = main20.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מכונת גלידה", ParentTypeId = main20.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מכונת כביסה", ParentTypeId = main20.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מכונת קפה", ParentTypeId = main20.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מכונת תפירה", ParentTypeId = main20.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מכשירי פקס", ParentTypeId = main20.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מנגל", ParentTypeId = main20.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מסחטה", ParentTypeId = main20.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מעבד מזון", ParentTypeId = main20.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מפזר חום", ParentTypeId = main20.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מקפיא", ParentTypeId = main20.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מקרן", ParentTypeId = main20.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מקרר", ParentTypeId = main20.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מקרר יינות", ParentTypeId = main20.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מקרר מיני בר", ParentTypeId = main20.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מתקני / מטהרי מים", ParentTypeId = main20.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ניקוי בקיטור", ParentTypeId = main20.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "סדין חשמלי", ParentTypeId = main20.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "סטרימר", ParentTypeId = main20.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "סיר בישול", ParentTypeId = main20.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "סיר טיגון", ParentTypeId = main20.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "פלטה חשמלית", ParentTypeId = main20.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "קולט אדים", ParentTypeId = main20.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "קומקום חשמלי", ParentTypeId = main20.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "רדיאטור", ParentTypeId = main20.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "שואבי אבק", ParentTypeId = main20.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "שלטים", ParentTypeId = main20.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "תנור אפייה", ParentTypeId = main20.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "תנור חימום", ParentTypeId = main20.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אחר", ParentTypeId = main20.Id , HasManufacturer = false });


var main21 =  new SecondHandType() { Name = "מחשבים וציוד נלווה", HasManufacturer = false };
EFContext.Get().SecondHandTypes.Add(main21);
EFContext.Get().SaveChanges();

// sub types of מחשבים וציוד נלווה:

EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "Ebook Reader", ParentTypeId = main21.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "tablet טאבלט", ParentTypeId = main21.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אביזרים", ParentTypeId = main21.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אייפד אייר", ParentTypeId = main21.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אייפד מיני iPad mini", ParentTypeId = main21.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אייפד מיני iPad mini 2", ParentTypeId = main21.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אייפד1 iPad1", ParentTypeId = main21.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אייפד2 iPad2", ParentTypeId = main21.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אייפד3 iPad3", ParentTypeId = main21.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אייפד4 iPad4", ParentTypeId = main21.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "חומרה", ParentTypeId = main21.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מדפסות", ParentTypeId = main21.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מחשב כף יד", ParentTypeId = main21.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מחשב נייד", ParentTypeId = main21.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מחשב שולחני", ParentTypeId = main21.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מילון אלקטרוני", ParentTypeId = main21.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מסכים", ParentTypeId = main21.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "משחקי מחשב", ParentTypeId = main21.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ניווט GPS", ParentTypeId = main21.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "סורקים", ParentTypeId = main21.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "עט דיגיטלי", ParentTypeId = main21.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "צורבים", ParentTypeId = main21.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "שרתים", ParentTypeId = main21.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "תוכנות", ParentTypeId = main21.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אחר", ParentTypeId = main21.Id , HasManufacturer = false });


var main22 =  new SecondHandType() { Name = "מיגון לבית ולעסק", HasManufacturer = false };
EFContext.Get().SecondHandTypes.Add(main22);
EFContext.Get().SaveChanges();

// sub types of מיגון לבית ולעסק:

EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אזעקה", ParentTypeId = main22.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אינטרקום", ParentTypeId = main22.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "כספת", ParentTypeId = main22.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מכשיר ציתות והאזנה", ParentTypeId = main22.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מצלמות וטלוויזיה במעגל סגור", ParentTypeId = main22.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "סורגים", ParentTypeId = main22.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ציוד כיבוי אש", ParentTypeId = main22.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "שער", ParentTypeId = main22.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אחר", ParentTypeId = main22.Id , HasManufacturer = false });


var main23 =  new SecondHandType() { Name = "מנויים וכרטיסים", HasManufacturer = false };
EFContext.Get().SecondHandTypes.Add(main23);
EFContext.Get().SaveChanges();

// sub types of מנויים וכרטיסים:

EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מנויים לחדר כושר", ParentTypeId = main23.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מנוי לתיאטרון", ParentTypeId = main23.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מנוי למשחקי ספורט", ParentTypeId = main23.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מנוי לחוגי ספורט", ParentTypeId = main23.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מנוי לקאנטרי\\ בריכה", ParentTypeId = main23.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "הצגות תיאטרון", ParentTypeId = main23.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "הופעות מוסיקליות", ParentTypeId = main23.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מופעי מחול וריקוד", ParentTypeId = main23.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מופעים לילדים", ParentTypeId = main23.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "כרטיס משחקי ספורט", ParentTypeId = main23.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "כרטיס קולנוע", ParentTypeId = main23.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "סטנד אפ  / בידור", ParentTypeId = main23.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "פארקים ואטרקציות", ParentTypeId = main23.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "פסטיבל / פסטיגל", ParentTypeId = main23.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אחר", ParentTypeId = main23.Id , HasManufacturer = false });


var main24 =  new SecondHandType() { Name = "משחקים וצעצועים", HasManufacturer = false };
EFContext.Get().SecondHandTypes.Add(main24);
EFContext.Get().SaveChanges();

// sub types of משחקים וצעצועים:

EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "בוגרים", ParentTypeId = main24.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ילדים", ParentTypeId = main24.Id , HasManufacturer = false });


var main25 =  new SecondHandType() { Name = "סטוקים", HasManufacturer = false };
EFContext.Get().SecondHandTypes.Add(main25);
EFContext.Get().SaveChanges();

// sub types of סטוקים:

EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "כללי", ParentTypeId = main25.Id , HasManufacturer = false });


var main26 =  new SecondHandType() { Name = "סטריאו", HasManufacturer = false };
EFContext.Get().SecondHandTypes.Add(main26);
EFContext.Get().SaveChanges();

// sub types of סטריאו:

EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אביזרים", ParentTypeId = main26.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אייפוד iPod", ParentTypeId = main26.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אקולייזר", ParentTypeId = main26.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "דיסקמן", ParentTypeId = main26.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "טייפ", ParentTypeId = main26.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "טייפ מנהלים", ParentTypeId = main26.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מגבר", ParentTypeId = main26.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מיני דיסק", ParentTypeId = main26.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מערכות סטריאו", ParentTypeId = main26.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מערכת קולנוע ביתית", ParentTypeId = main26.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "נגן דיסקים", ParentTypeId = main26.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "נגני mp3 / mp4", ParentTypeId = main26.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "פטיפון", ParentTypeId = main26.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "רדיו טייפ\\ דיסק", ParentTypeId = main26.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "רמקולים", ParentTypeId = main26.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "רסיבר", ParentTypeId = main26.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אחר", ParentTypeId = main26.Id , HasManufacturer = false });


var main27 =  new SecondHandType() { Name = "סלולרי", HasManufacturer = false };
EFContext.Get().SecondHandTypes.Add(main27);
EFContext.Get().SaveChanges();

// sub types of סלולרי:

EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "דיבוריות", ParentTypeId = main27.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "כבל נתונים", ParentTypeId = main27.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "כרטיס זכרון", ParentTypeId = main27.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "כרטיס סים", ParentTypeId = main27.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מגיני מסך וכיסויים", ParentTypeId = main27.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מודם סלולרי", ParentTypeId = main27.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מטען", ParentTypeId = main27.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מכשיר סלולרי", ParentTypeId = main27.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מספרי זהב", ParentTypeId = main27.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "סוללה", ParentTypeId = main27.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "שירות לסלולרי", ParentTypeId = main27.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "תושבות/מעמדים", ParentTypeId = main27.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "Smartwatch", ParentTypeId = main27.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אחר", ParentTypeId = main27.Id , HasManufacturer = false });


var main28 =  new SecondHandType() { Name = "ספורט", HasManufacturer = false };
EFContext.Get().SecondHandTypes.Add(main28);
EFContext.Get().SaveChanges();

// sub types of ספורט:

EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אביזרים לסנפלינג", ParentTypeId = main28.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אומנויות לחימה", ParentTypeId = main28.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ביגוד ונעליים מקצועיות", ParentTypeId = main28.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ג'אגלינג/להטוטנות", ParentTypeId = main28.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "גולף", ParentTypeId = main28.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "הוקי", ParentTypeId = main28.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "וויקבורד", ParentTypeId = main28.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "טיסנים ומסוקים", ParentTypeId = main28.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "טרמפולינה", ParentTypeId = main28.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מחבטי טניס", ParentTypeId = main28.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מכונית על שלט רחוק", ParentTypeId = main28.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מכשירי כושר ביתיים", ParentTypeId = main28.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מנוי לחדר כושר", ParentTypeId = main28.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מצנח רחיפה", ParentTypeId = main28.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "סנובורד", ParentTypeId = main28.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ספורט ימי", ParentTypeId = main28.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "סקייטבורד", ParentTypeId = main28.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "עפיפונים", ParentTypeId = main28.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ציוד דיג", ParentTypeId = main28.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ציוד לכדורגל", ParentTypeId = main28.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ציוד צלילה", ParentTypeId = main28.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "רולר בליידס וגלגיליות", ParentTypeId = main28.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "שולחנות משחק", ParentTypeId = main28.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "שעוני דופק/פולאר", ParentTypeId = main28.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אביזרי ספורט", ParentTypeId = main28.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אביזרים לסקי", ParentTypeId = main28.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אחר", ParentTypeId = main28.Id , HasManufacturer = false });


var main29 =  new SecondHandType() { Name = "ספרות וחומרי לימוד", HasManufacturer = false };
EFContext.Get().SecondHandTypes.Add(main29);
EFContext.Get().SaveChanges();

// sub types of ספרות וחומרי לימוד:

EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אינצקלופדיה", ParentTypeId = main29.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מאמרים", ParentTypeId = main29.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מילונים", ParentTypeId = main29.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "סיפרות", ParentTypeId = main29.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ספרות מקצועית", ParentTypeId = main29.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ספרי אומנות", ParentTypeId = main29.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ספרי בישול", ParentTypeId = main29.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ספרי ילדים", ParentTypeId = main29.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ספרי לימוד", ParentTypeId = main29.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ספרי עיון ואלבומים", ParentTypeId = main29.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ספרים ומאמרים", ParentTypeId = main29.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ספרים ומפות", ParentTypeId = main29.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "שפה זרה", ParentTypeId = main29.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אחר", ParentTypeId = main29.Id , HasManufacturer = false });


var main30 =  new SecondHandType() { Name = "עסקים למכירה\\מסירה", HasManufacturer = false };
EFContext.Get().SecondHandTypes.Add(main30);
EFContext.Get().SaveChanges();

// sub types of עסקים למכירה\מסירה:

EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אופנה וביגוד", ParentTypeId = main30.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אינטרנט ודומיינים", ParentTypeId = main30.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אירועים", ParentTypeId = main30.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "בידור ומוסיקה", ParentTypeId = main30.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "בתי קפה ומסעדות", ParentTypeId = main30.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "הזדמנויות עסקיות", ParentTypeId = main30.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "הייטק", ParentTypeId = main30.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "זכיינות", ParentTypeId = main30.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "חנויות", ParentTypeId = main30.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "חקלאות", ParentTypeId = main30.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "טיפוח וקוסמטיקה", ParentTypeId = main30.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ייצור", ParentTypeId = main30.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מוסכים", ParentTypeId = main30.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מועדונים וברים", ParentTypeId = main30.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מזון", ParentTypeId = main30.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מינימרקט/סופרמרקט", ParentTypeId = main30.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מסחר", ParentTypeId = main30.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "משקיעים פוטנציאלים", ParentTypeId = main30.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מתקני ילדים", ParentTypeId = main30.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "עבודה מהבית", ParentTypeId = main30.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "עסקים בחו'ל", ParentTypeId = main30.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "פיצוציה/קיוסק", ParentTypeId = main30.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "קווי חלוקה", ParentTypeId = main30.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "קליניקה", ParentTypeId = main30.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "שותפות", ParentTypeId = main30.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "תעשייה", ParentTypeId = main30.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "כללי", ParentTypeId = main30.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אחר", ParentTypeId = main30.Id , HasManufacturer = false });


var main31 =  new SecondHandType() { Name = "ציוד לאירועים", HasManufacturer = false };
EFContext.Get().SecondHandTypes.Add(main31);
EFContext.Get().SaveChanges();

// sub types of ציוד לאירועים:

EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אביזרי עיצוב", ParentTypeId = main31.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אוהל", ParentTypeId = main31.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "בר", ParentTypeId = main31.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "חופה", ParentTypeId = main31.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "כיסא כלה", ParentTypeId = main31.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "עגלת מזון", ParentTypeId = main31.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ציוד הגברה", ParentTypeId = main31.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אחר", ParentTypeId = main31.Id , HasManufacturer = false });


var main32 =  new SecondHandType() { Name = "ציוד לדי.ג'י. ולאולפנים", HasManufacturer = false };
EFContext.Get().SecondHandTypes.Add(main32);
EFContext.Get().SaveChanges();

// sub types of ציוד לדי.ג'י. ולאולפנים:

EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אביזרים", ParentTypeId = main32.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "פלטות די. ג'יי", ParentTypeId = main32.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "פנס / מצביע  לייזר", ParentTypeId = main32.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ציוד הגברה", ParentTypeId = main32.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ציוד לאולפנים", ParentTypeId = main32.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "תאורה", ParentTypeId = main32.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מיקרופון", ParentTypeId = main32.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אחר", ParentTypeId = main32.Id , HasManufacturer = false });


var main33 =  new SecondHandType() { Name = "ציוד לעסקים", HasManufacturer = false };
EFContext.Get().SecondHandTypes.Add(main33);
EFContext.Get().SaveChanges();

// sub types of ציוד לעסקים:

EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "בובות ראווה", ParentTypeId = main33.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "חדר קירור", ParentTypeId = main33.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "טלפון שקלים", ParentTypeId = main33.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "כלי צורפות", ParentTypeId = main33.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ליצנות וקרקס", ParentTypeId = main33.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מזון ומשקאות", ParentTypeId = main33.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מטבח תעשייתי", ParentTypeId = main33.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מכונות קרח", ParentTypeId = main33.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מכונת מזון", ParentTypeId = main33.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מכונת סיגריות", ParentTypeId = main33.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מכונת שתייה", ParentTypeId = main33.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מכונת תפירה", ParentTypeId = main33.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מקפיא", ParentTypeId = main33.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מקרר", ParentTypeId = main33.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "משקל", ParentTypeId = main33.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מתנפחים", ParentTypeId = main33.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ציוד אלקטרוניקה", ParentTypeId = main33.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ציוד לחדרי כושר", ParentTypeId = main33.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ציוד לחקלאות", ParentTypeId = main33.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ציוד למוסך", ParentTypeId = main33.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ציוד למסעדות/בתי קפה", ParentTypeId = main33.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ציוד למספרה", ParentTypeId = main33.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ציוד לקליניקות ומרפאות", ParentTypeId = main33.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ציוד תפירה", ParentTypeId = main33.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "קונדטוריות ומאפיות", ParentTypeId = main33.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "קופה רושמת", ParentTypeId = main33.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ריהוט לעסקים", ParentTypeId = main33.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "תנור תעשייתי", ParentTypeId = main33.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אחר", ParentTypeId = main33.Id , HasManufacturer = false });


var main34 =  new SecondHandType() { Name = "ציוד לתעשייה", HasManufacturer = false };
EFContext.Get().SecondHandTypes.Add(main34);
EFContext.Get().SaveChanges();

// sub types of ציוד לתעשייה:

EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "גנרטורים תעשייתים", ParentTypeId = main34.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מיכלים וחביות", ParentTypeId = main34.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מכולות", ParentTypeId = main34.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מכונות", ParentTypeId = main34.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מכונות בטון", ParentTypeId = main34.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מסועים", ParentTypeId = main34.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "משאבות", ParentTypeId = main34.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "פיגומים", ParentTypeId = main34.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "קומפרסור/מדחס", ParentTypeId = main34.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "רתכות", ParentTypeId = main34.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ציוד כללי לתעשייה", ParentTypeId = main34.Id , HasManufacturer = false });


var main35 =  new SecondHandType() { Name = "ציוד להשכרה", HasManufacturer = false };
EFContext.Get().SecondHandTypes.Add(main35);
EFContext.Get().SaveChanges();

// sub types of ציוד להשכרה:

EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ביגוד ואביזרים", ParentTypeId = main35.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "כלי עבודה", ParentTypeId = main35.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ציוד לאירועים", ParentTypeId = main35.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ציוד לעסקים", ParentTypeId = main35.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אחר", ParentTypeId = main35.Id , HasManufacturer = false });


var main36 =  new SecondHandType() { Name = "ציוד משרדי", HasManufacturer = false };
EFContext.Get().SecondHandTypes.Add(main36);
EFContext.Get().SaveChanges();

// sub types of ציוד משרדי:

EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "גליוטינות", ParentTypeId = main36.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "כלי כתיבה", ParentTypeId = main36.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מגרסות", ParentTypeId = main36.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מחשבונים", ParentTypeId = main36.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מכונת צילום", ParentTypeId = main36.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מכשירי כריכה ולמינציה", ParentTypeId = main36.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מרכזיות", ParentTypeId = main36.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "עמדת קבלה", ParentTypeId = main36.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "פקס", ParentTypeId = main36.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "שולחן משרדי", ParentTypeId = main36.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "תכולת משרד", ParentTypeId = main36.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אחר", ParentTypeId = main36.Id , HasManufacturer = false });


var main37 =  new SecondHandType() { Name = "ציוד סיעודי/ רפואי", HasManufacturer = false };
EFContext.Get().SecondHandTypes.Add(main37);
EFContext.Get().SaveChanges();

// sub types of ציוד סיעודי/ רפואי:

EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "הליכון", ParentTypeId = main37.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "כסא גלגלים", ParentTypeId = main37.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מיטה", ParentTypeId = main37.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מיטת עיסוי", ParentTypeId = main37.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "עזרי שמיעה", ParentTypeId = main37.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "קלנועית", ParentTypeId = main37.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ציוד נלווה", ParentTypeId = main37.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אחר", ParentTypeId = main37.Id , HasManufacturer = false });


var main38 =  new SecondHandType() { Name = "צילום", HasManufacturer = false };
EFContext.Get().SecondHandTypes.Add(main38);
EFContext.Get().SaveChanges();

// sub types of צילום:

EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אביזרים", ParentTypeId = main38.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מצלמה דיגיטלית", ParentTypeId = main38.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מצלמת וידאו", ParentTypeId = main38.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מצלמת פילם", ParentTypeId = main38.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מצלמת רפלקס דיג'י", ParentTypeId = main38.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "עדשות", ParentTypeId = main38.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אחר", ParentTypeId = main38.Id , HasManufacturer = false });


var main39 =  new SecondHandType() { Name = "קונסולות משחק", HasManufacturer = false };
EFContext.Get().SecondHandTypes.Add(main39);
EFContext.Get().SaveChanges();

// sub types of קונסולות משחק:

EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "משחקים", ParentTypeId = main39.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אביזרים", ParentTypeId = main39.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "פלייסטיישן 4", ParentTypeId = main39.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "פלייסטיישן 3", ParentTypeId = main39.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "פלייסטיישן 2", ParentTypeId = main39.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "פלייסטיישן 1", ParentTypeId = main39.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "PS vita", ParentTypeId = main39.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "PSP", ParentTypeId = main39.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "X-Box One", ParentTypeId = main39.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "X-Box360", ParentTypeId = main39.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "X-Box", ParentTypeId = main39.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "Wii U", ParentTypeId = main39.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "WII", ParentTypeId = main39.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "גיימבוי", ParentTypeId = main39.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "גיימקיוב", ParentTypeId = main39.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "נינטנדו", ParentTypeId = main39.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אחר", ParentTypeId = main39.Id , HasManufacturer = false });


var main40 =  new SecondHandType() { Name = "טיפוח ובריאות", HasManufacturer = false };
EFContext.Get().SecondHandTypes.Add(main40);
EFContext.Get().SaveChanges();

// sub types of טיפוח ובריאות:

EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "לציפורניים", ParentTypeId = main40.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "לשיער", ParentTypeId = main40.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "טיפוח", ParentTypeId = main40.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מחליק / מסלסל שיער", ParentTypeId = main40.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מייבש שיער", ParentTypeId = main40.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מכונת גילוח", ParentTypeId = main40.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מכונת תספורת", ParentTypeId = main40.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מסיר שיער", ParentTypeId = main40.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ציוד מקצועי", ParentTypeId = main40.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "תמרוקים", ParentTypeId = main40.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אחר", ParentTypeId = main40.Id , HasManufacturer = false });


var main41 =  new SecondHandType() { Name = "קורקינטים", HasManufacturer = false };
EFContext.Get().SecondHandTypes.Add(main41);
EFContext.Get().SaveChanges();

// sub types of קורקינטים:

EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אביזרים", ParentTypeId = main41.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "סגווי", ParentTypeId = main41.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "קורקינט", ParentTypeId = main41.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "קורקינט בנזין", ParentTypeId = main41.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "קורקינט חשמלי", ParentTypeId = main41.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אחר", ParentTypeId = main41.Id , HasManufacturer = false });


var main42 =  new SecondHandType() { Name = "ריהוט", HasManufacturer = false };
EFContext.Get().SecondHandTypes.Add(main42);
EFContext.Get().SaveChanges();

// sub types of ריהוט:

EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ארונות", ParentTypeId = main42.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "דלתות", ParentTypeId = main42.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "חדרי שינה", ParentTypeId = main42.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "כוורת", ParentTypeId = main42.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "כורסאות", ParentTypeId = main42.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "כורסאות  טלויזיה", ParentTypeId = main42.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "כורסאות ומושבי עיסוי", ParentTypeId = main42.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "כיסא נדנדה", ParentTypeId = main42.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "כסאות", ParentTypeId = main42.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מדפים", ParentTypeId = main42.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מוטות תלייה", ParentTypeId = main42.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מזנון / ויטרינה", ParentTypeId = main42.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מזרנים", ParentTypeId = main42.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מטבח", ParentTypeId = main42.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מיטות", ParentTypeId = main42.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מעמד לדיסקים", ParentTypeId = main42.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מראה", ParentTypeId = main42.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "סלון", ParentTypeId = main42.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ספות", ParentTypeId = main42.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ספריה", ParentTypeId = main42.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ענתיקות", ParentTypeId = main42.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "פוף", ParentTypeId = main42.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "פינת אוכל", ParentTypeId = main42.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ריהוט לגינה", ParentTypeId = main42.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ריהוט לחדרי ילדים", ParentTypeId = main42.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ריהוט משרדי", ParentTypeId = main42.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "שולחן טלוויזיה", ParentTypeId = main42.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "שולחן מחשב", ParentTypeId = main42.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "שולחנות", ParentTypeId = main42.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "שטיחים", ParentTypeId = main42.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "שידות", ParentTypeId = main42.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "שעון קיר", ParentTypeId = main42.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "תכולת דירה", ParentTypeId = main42.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אחר", ParentTypeId = main42.Id , HasManufacturer = false });


var main43 =  new SecondHandType() { Name = "שוברי זיכוי \\ תלושים \\שונות", HasManufacturer = false };
EFContext.Get().SecondHandTypes.Add(main43);
EFContext.Get().SaveChanges();

// sub types of שוברי זיכוי \ תלושים \שונות:

EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "זיכויים ושוברים", ParentTypeId = main43.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "כרטיסי חנייה", ParentTypeId = main43.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מיוחדים", ParentTypeId = main43.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "סדנאות", ParentTypeId = main43.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "קופונים", ParentTypeId = main43.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "קורסים", ParentTypeId = main43.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "תלושים ותווי שי", ParentTypeId = main43.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אחר", ParentTypeId = main43.Id , HasManufacturer = false });


var main44 =  new SecondHandType() { Name = "תכשיטים", HasManufacturer = false };
EFContext.Get().SecondHandTypes.Add(main44);
EFContext.Get().SaveChanges();

// sub types of תכשיטים:

EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "חריטה", ParentTypeId = main44.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "טבעות", ParentTypeId = main44.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "סיכות", ParentTypeId = main44.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "עגילים", ParentTypeId = main44.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "צמידים", ParentTypeId = main44.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "קופסאות וסטנדים", ParentTypeId = main44.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "שעונים", ParentTypeId = main44.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "שרשראות", ParentTypeId = main44.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "תליונים", ParentTypeId = main44.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אחר", ParentTypeId = main44.Id , HasManufacturer = false });


var main45 =  new SecondHandType() { Name = "תקשורת", HasManufacturer = false };
EFContext.Get().SecondHandTypes.Add(main45);
EFContext.Get().SaveChanges();

// sub types of תקשורת:

EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אנטנות/צלחות לווין/ממירים", ParentTypeId = main45.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ארונות תקשורת", ParentTypeId = main45.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "חבילות תקשורת", ParentTypeId = main45.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מכשירי כריזה", ParentTypeId = main45.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מכשירי קשר ואלחוט", ParentTypeId = main45.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "עזרי שמיעה", ParentTypeId = main45.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אחר", ParentTypeId = main45.Id , HasManufacturer = false });


var main46 =  new SecondHandType() { Name = "ציוד לבית ספר", HasManufacturer = false };
EFContext.Get().SecondHandTypes.Add(main46);
EFContext.Get().SaveChanges();

// sub types of ציוד לבית ספר:

EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "יומנים", ParentTypeId = main46.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ילקוט", ParentTypeId = main46.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "לוח", ParentTypeId = main46.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מחברות", ParentTypeId = main46.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "מילון כיס", ParentTypeId = main46.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "קלמר", ParentTypeId = main46.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "תלבושת אחידה", ParentTypeId = main46.Id , HasManufacturer = false });


var main47 =  new SecondHandType() { Name = "תאורה ונברשות", HasManufacturer = false };
EFContext.Get().SecondHandTypes.Add(main47);
EFContext.Get().SaveChanges();

// sub types of תאורה ונברשות:

EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אביזרים", ParentTypeId = main47.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אהילים", ParentTypeId = main47.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "בתי מנורה", ParentTypeId = main47.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "נברשות", ParentTypeId = main47.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "נורות", ParentTypeId = main47.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "נורות ומנורות", ParentTypeId = main47.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "ספוטים", ParentTypeId = main47.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "תאורת גן", ParentTypeId = main47.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "תאורת לילה", ParentTypeId = main47.Id , HasManufacturer = false });
EFContext.Get().SecondHandTypes.Add(new SecondHandType() {  Name = "אחר", ParentTypeId = main47.Id , HasManufacturer = false });

            
        }

        private static void GenerateSecondHandItems()
        {

            Random rnd = new Random();

            Region[] regions = EFContext.Get().Regions.ToArray();

            Category SecondHandCategory = EFContext.Get().Categories.FirstOrDefault(c => c.Name == "יד שניה");

            int sellersCount = EFContext.Get().Sellers.Count();

            Seller seller = EFContext.Get().Sellers.OrderBy(s => s.Id).Skip(rnd.Next(sellersCount - 1)).Take(1).First();

            SecondHandType[] mainTypes = EFContext.Get().SecondHandTypes.Where(sh => !sh.ParentTypeId.HasValue).ToArray();
            

            List<SecondHand> secondHandItems = new List<SecondHand>();

            for (int i = 0; i < 10000; i++)
            {
                SecondHandType mainType;
                SecondHandType subType;
                while (true)
                {
                    mainType = mainTypes[rnd.Next(1, mainTypes.Length - 1)];
                    SecondHandType[] childTypes = EFContext.Get().SecondHandTypes.Where(st => st.ParentTypeId.HasValue && st.ParentTypeId.Value == mainType.Id).ToArray();
                    if (childTypes.Length > 0)
                    {
                        subType = childTypes[rnd.Next(childTypes.Length - 1)];
                        break;
                    }
                }

                secondHandItems.Add(
                    new SecondHand()
                    {
                        CategoryId = SecondHandCategory.Id,
                        RegionId = regions[rnd.Next(regions.Length - 1)].Id,
                        Created = DateTime.Now,
                        Desc = RandomWordsHelper(),
                        StateId = rnd.Next(1, 5),
                        LastModified = DateTime.Now,
                        LastPopedUp = DateTime.Now,
                        Title = RandomWordsHelper(),
                        Price = rnd.Next(5, 150) * 1000,
                        TypeId = mainType.Id,
                        SubTypeId = subType.Id,
                        SellerId = seller.Id,
                        Phone1 = RandomCellPhoneHelper(),
                        Phone2 = RandomPhoneHelper(),
                    });
            }

            EFContext.Get().SecondHandItems.AddRange(secondHandItems);
          
        }



        private static void Appliances()
        {

            Random rnd = new Random();

            Region[] regions = EFContext.Get().Regions.ToArray();

            Category SecondHandCategory = EFContext.Get().Categories.FirstOrDefault(c => c.Name == "יד שניה");

            int sellersCount = EFContext.Get().Sellers.Count();

            Seller seller = EFContext.Get().Sellers.OrderBy(s => s.Id).Skip(rnd.Next(sellersCount - 1)).Take(1).First();

            SecondHandType[] mainTypes = EFContext.Get().SecondHandTypes.Where(sh => !sh.ParentTypeId.HasValue).ToArray();


            List<SecondHand> secondHandItems = new List<SecondHand>();

            for (int i = 0; i < 10000; i++)
            {
                SecondHandType mainType;
                SecondHandType subType;
                while (true)
                {
                    mainType = mainTypes[rnd.Next(1, mainTypes.Length - 1)];
                    SecondHandType[] childTypes = EFContext.Get().SecondHandTypes.Where(st => st.ParentTypeId.HasValue && st.ParentTypeId.Value == mainType.Id).ToArray();
                    if (childTypes.Length > 0)
                    {
                        subType = childTypes[rnd.Next(childTypes.Length - 1)];
                        break;
                    }
                }

                secondHandItems.Add(
                    new SecondHand()
                    {
                        CategoryId = SecondHandCategory.Id,
                        RegionId = regions[rnd.Next(regions.Length - 1)].Id,
                        Created = DateTime.Now,
                        Desc = RandomWordsHelper(),
                        StateId = rnd.Next(1, 5),
                        LastModified = DateTime.Now,
                        LastPopedUp = DateTime.Now,
                        Title = RandomWordsHelper(),
                        Price = rnd.Next(5, 150) * 1000,
                        TypeId = mainType.Id,
                        SubTypeId = subType.Id,
                        SellerId = seller.Id,
                        Phone1 = RandomCellPhoneHelper(),
                        Phone2 = RandomPhoneHelper(),
                    });
            }

            EFContext.Get().SecondHandItems.AddRange(secondHandItems);

        }

    


        private static void GenerateUsersAndGroups()
        {
            var usersGroup = new UsersGroupBase() { Name = "Sellers" };
            usersGroup.Users = new List<UserBase>();
            usersGroup.Users.Add(new UserBase()
            {
                UserName = "Shuki",
                Created = DateTime.Now,
                Email = "Shuki@gmail.com",
                IsActive = true,
                LastVisited = DateTime.Now,
                PasswordHash = "1234",
                HasToChangePass = false,
            });
            EFContext.Get().UsersGroups.Add(usersGroup);
        }

        private static void GenerateSellers()
        {

            var shuki = EFContext.Get().Users.First();

            EFContext.Get().Sellers.Add(new Seller()
            {
                Name = "Shuki patishi",
                UserId = shuki.Id,
                FullAddress = "simtat tech career , kibutz nachshon",
                Phone1 = "093452352",
                Phone2 = "0572828364"
            });
        }

        private static void GenerateCategories()
        {
            EFContext.Get().Categories.AddRange(
                new List<Category>()
                {
                        new Category()
                        {
                            Name = "רכב",
                            ChildCategories = new List<Category>()
                            {
                                new Category() { Name = "פרטי" },
                                new Category() { Name = "מסחרי" },
                                new Category() { Name = "ג'יפים" },
                                new Category() { Name = "משאיות" },
                                new Category() { Name = "אופנועים" },
                                new Category() { Name = "קטנועים" },
                            }
                        },
                        new Category()
                        {
                            Name = "יד שניה",
                            ChildCategories = new List<Category>()
                            {
                                new Category() { Name = "מוצרי יד שניה" },
                            }
                        },
                });
        }

        private static void GenerateRegions()
        {
            EFContext.Get().Regions.AddRange(
                new List<Region>()
                {
                        new Region()
                        {
                            Name = "איזור צפון",
                            ChildRegions = new List<Region>()
                            {
                                new Region() { Name = "חיפה וחוף הכרמל" },
                                new Region() { Name = "קריות" },
                                new Region() { Name = "עכו/נהריה" },
                                new Region() { Name = "גליל ועמקים" },
                                new Region() { Name = "טבריה והסביבה" },
                                new Region() { Name = "עמק יזרעאל" },
                                new Region() { Name = "כרמיאל והסביבה" },
                                new Region() { Name = "מושבים בצפון" },
                                
                            }
                        },
                        new Region()
                        {
                            Name = "איזור השרון והסביבה",
                            ChildRegions = new List<Region>()
                            {
                                new Region() { Name = "זכרון - בנימינה" },
                                new Region() { Name = "חדרה וישובי עמק חפר" },
                                new Region() { Name = "פרדס חנה - כרכור" },
                                new Region() { Name = "ישובי השומרון" },
                                new Region() { Name = "נתניה והסביבה" },
                                new Region() { Name = "קיסריה והסביבה" },
                                new Region() { Name = "רמת השרון - הרצליה" },
                                new Region() { Name = "רעננה - כפר סבא" },
                                new Region() { Name = "הוד השרון והסביבה" },
                                new Region() { Name = "מושבים בשרון" },
                            }
                        },
                        new Region()
                        {
                            Name = "איזור המרכז",
                            ChildRegions = new List<Region>()
                            {
                                new Region() { Name = "תל אביב" },
                                new Region() { Name = "ראשל\"צ והסביבה" },
                                new Region() { Name = "חולון - בת ים" },
                                new Region() { Name = "רמת גן - גבעתיים" },
                                new Region() { Name = "פתח תקוה והסביבה" },
                                new Region() { Name = "ראש העין והסביבה" },
                                new Region() { Name = "בקעת אונו" },
                                new Region() { Name = "מושבים במרכז" },
                            }
                        },
                        new Region()
                        {
                            Name = "ירושלים והסביבה",
                            ChildRegions = new List<Region>()
                            {
                                new Region() { Name = "מודיעין והסביבה" },
                                new Region() { Name = "בית שמש והסביבה" },
                                new Region() { Name = "מושבים באיזור ירושלים" },
                            }
                        },
                        new Region()
                        {
                            Name = "איזור השפלה והסביבה",
                            ChildRegions = new List<Region>()
                            {
                                new Region() { Name = "נס ציונה - רחובות" },
                                new Region() { Name = "אשדוד - אשקלון" },
                                new Region() { Name = "רמלה - לוד" },
                                new Region() { Name = "גדרה יבנה והסביבה" },
                                new Region() { Name = "מושבים בשפלה" },
                            }
                        },
                        new Region()
                        {
                            Name = "איזור דרום",
                            ChildRegions = new List<Region>()
                            {
                                new Region() { Name = "באר שבע והסביבה" },
                                new Region() { Name = "קרית גת והסביבה" },
                                new Region() { Name = "אילת והערבה" },
                                new Region() { Name = "מושבים בדרום" },
                            }
                        },

                 });
        }

        private static void GenerateVehicleManufacturerAndModels()
        {
            List<VehicleManufacturer> mans = new List<VehicleManufacturer>();
            VehicleManufacturer man1 = new VehicleManufacturer() { Type = 4, Name = "AJP" };
            man1.Models = new List<VehicleModel>();
            man1.Models.Add(new VehicleModel() { Name = "PR3 125 Enduro Pro" });
            man1.Models.Add(new VehicleModel() { Name = "PR3 200 Enduro Pro" });
            man1.Models.Add(new VehicleModel() { Name = "PR4 125 Enduro Pro" });
            man1.Models.Add(new VehicleModel() { Name = "PR4 200 Enduro Pro" });
            man1.Models.Add(new VehicleModel() { Name = "PR5 250 LC" });
            mans.Add(man1);
            VehicleManufacturer man2 = new VehicleManufacturer() { Type = 4, Name = "HM" };
            man2.Models = new List<VehicleModel>();
            man2.Models.Add(new VehicleModel() { Name = "CRE 125R" });
            man2.Models.Add(new VehicleModel() { Name = "CRE F125 BajaRR" });
            man2.Models.Add(new VehicleModel() { Name = "CRE F250R" });
            man2.Models.Add(new VehicleModel() { Name = "CRE F250X" });
            man2.Models.Add(new VehicleModel() { Name = "CRE F300R" });
            man2.Models.Add(new VehicleModel() { Name = "CRE F300X" });
            man2.Models.Add(new VehicleModel() { Name = "CRE F450R" });
            man2.Models.Add(new VehicleModel() { Name = "CRE F450X" });
            man2.Models.Add(new VehicleModel() { Name = "CRE F500X" });
            man2.Models.Add(new VehicleModel() { Name = "CRE Six Comp 2T 12" });
            man2.Models.Add(new VehicleModel() { Name = "CRM 125R" });
            man2.Models.Add(new VehicleModel() { Name = "CRM F450R" });
            man2.Models.Add(new VehicleModel() { Name = "CRM F450X" });
            mans.Add(man2);
            VehicleManufacturer man3 = new VehicleManufacturer() { Type = 4, Name = "MV Agsuta" };
            man3.Models = new List<VehicleModel>();
            man3.Models.Add(new VehicleModel() { Name = "Brutale 1090" });
            man3.Models.Add(new VehicleModel() { Name = "Brutale 800" });
            man3.Models.Add(new VehicleModel() { Name = "F3 675" });
            man3.Models.Add(new VehicleModel() { Name = "F3 800" });
            man3.Models.Add(new VehicleModel() { Name = "F4" });
            man3.Models.Add(new VehicleModel() { Name = "Rivale 800" });
            mans.Add(man3);
            VehicleManufacturer man4 = new VehicleManufacturer() { Type = 4, Name = "MZ" };
            man4.Models = new List<VehicleModel>();
            man4.Models.Add(new VehicleModel() { Name = "251" });
            man4.Models.Add(new VehicleModel() { Name = "301" });
            man4.Models.Add(new VehicleModel() { Name = "NRX" });
            man4.Models.Add(new VehicleModel() { Name = "באגירה" });
            man4.Models.Add(new VehicleModel() { Name = "סקורפיו" });
            man4.Models.Add(new VehicleModel() { Name = "אחר" });
            mans.Add(man4);
            VehicleManufacturer man5 = new VehicleManufacturer() { Type = 4, Name = "TM Racing" };
            man5.Models = new List<VehicleModel>();
            man5.Models.Add(new VehicleModel() { Name = "EN 125" });
            man5.Models.Add(new VehicleModel() { Name = "EN 250" });
            man5.Models.Add(new VehicleModel() { Name = "EN 250 Fi ES" });
            man5.Models.Add(new VehicleModel() { Name = "EN 300" });
            man5.Models.Add(new VehicleModel() { Name = "EN 450 Fi ES" });
            mans.Add(man5);
            VehicleManufacturer man6 = new VehicleManufacturer() { Type = 4, Name = "אפריליה" };
            man6.Models = new List<VehicleModel>();
            man6.Models.Add(new VehicleModel() { Name = "RS125" });
            man6.Models.Add(new VehicleModel() { Name = "RSV4R" });
            man6.Models.Add(new VehicleModel() { Name = "RX125" });
            man6.Models.Add(new VehicleModel() { Name = "RX50" });
            man6.Models.Add(new VehicleModel() { Name = "RXV4.5" });
            man6.Models.Add(new VehicleModel() { Name = "SXV4.5" });
            man6.Models.Add(new VehicleModel() { Name = "SXV5.5" });
            man6.Models.Add(new VehicleModel() { Name = "דורסודורו 750" });
            man6.Models.Add(new VehicleModel() { Name = "טואונו V4" });
            man6.Models.Add(new VehicleModel() { Name = "מאנה 850" });
            man6.Models.Add(new VehicleModel() { Name = "פגאסו 650T" });
            man6.Models.Add(new VehicleModel() { Name = "קלאסיק 50" });
            man6.Models.Add(new VehicleModel() { Name = "שיבר 750 GT" });
            man6.Models.Add(new VehicleModel() { Name = "אחר" });
            mans.Add(man6);
            VehicleManufacturer man7 = new VehicleManufacturer() { Type = 4, Name = "ב.מ.וו" };
            man7.Models = new List<VehicleModel>();
            man7.Models.Add(new VehicleModel() { Name = "F650" });
            man7.Models.Add(new VehicleModel() { Name = "F650CS" });
            man7.Models.Add(new VehicleModel() { Name = "F650GS" });
            man7.Models.Add(new VehicleModel() { Name = "F650GS דקאר" });
            man7.Models.Add(new VehicleModel() { Name = "F650GS טווין" });
            man7.Models.Add(new VehicleModel() { Name = "F700GS" });
            man7.Models.Add(new VehicleModel() { Name = "F800GS" });
            man7.Models.Add(new VehicleModel() { Name = "F800R" });
            man7.Models.Add(new VehicleModel() { Name = "F800R" });
            man7.Models.Add(new VehicleModel() { Name = "F800R כריס פייפר" });
            man7.Models.Add(new VehicleModel() { Name = "F800S" });
            man7.Models.Add(new VehicleModel() { Name = "F800ST" });
            man7.Models.Add(new VehicleModel() { Name = "G450X" });
            man7.Models.Add(new VehicleModel() { Name = "G650GS" });
            man7.Models.Add(new VehicleModel() { Name = "G650XChallenge" });
            man7.Models.Add(new VehicleModel() { Name = "G650XCountry" });
            man7.Models.Add(new VehicleModel() { Name = "G650XMoto" });
            man7.Models.Add(new VehicleModel() { Name = "HP2 אנדורו" });
            man7.Models.Add(new VehicleModel() { Name = "HP2 מגהמוטו" });
            man7.Models.Add(new VehicleModel() { Name = "HP2 ספורט" });
            man7.Models.Add(new VehicleModel() { Name = "K100/1100RS" });
            man7.Models.Add(new VehicleModel() { Name = "K1200GT 2005" });
            man7.Models.Add(new VehicleModel() { Name = "K1200GT 2006-08" });
            man7.Models.Add(new VehicleModel() { Name = "K1200LT" });
            man7.Models.Add(new VehicleModel() { Name = "K1200R" });
            man7.Models.Add(new VehicleModel() { Name = "K1200R ספורט" });
            man7.Models.Add(new VehicleModel() { Name = "K1200RS" });
            man7.Models.Add(new VehicleModel() { Name = "K1200S" });
            man7.Models.Add(new VehicleModel() { Name = "K1300GT" });
            man7.Models.Add(new VehicleModel() { Name = "K1300R" });
            man7.Models.Add(new VehicleModel() { Name = "K1300S" });
            man7.Models.Add(new VehicleModel() { Name = "K75" });
            man7.Models.Add(new VehicleModel() { Name = "R1100/1150GS" });
            man7.Models.Add(new VehicleModel() { Name = "R1100/1150R" });
            man7.Models.Add(new VehicleModel() { Name = "R1100/1150RS" });
            man7.Models.Add(new VehicleModel() { Name = "R1100/1150RT" });
            man7.Models.Add(new VehicleModel() { Name = "R1100S" });
            man7.Models.Add(new VehicleModel() { Name = "R1150GS אדוונצ\"ר" });
            man7.Models.Add(new VehicleModel() { Name = "R1200C + מונטוק" });
            man7.Models.Add(new VehicleModel() { Name = "R1200GS" });
            man7.Models.Add(new VehicleModel() { Name = "R1200GS אדוונצ\"ר" });
            man7.Models.Add(new VehicleModel() { Name = "R1200R" });
            man7.Models.Add(new VehicleModel() { Name = "R1200RT" });
            man7.Models.Add(new VehicleModel() { Name = "R1200S" });
            man7.Models.Add(new VehicleModel() { Name = "R1200ST" });
            man7.Models.Add(new VehicleModel() { Name = "R80" });
            man7.Models.Add(new VehicleModel() { Name = "R80GS" });
            man7.Models.Add(new VehicleModel() { Name = "R850R" });
            man7.Models.Add(new VehicleModel() { Name = "S1000RR" });
            man7.Models.Add(new VehicleModel() { Name = "אחר" });
            mans.Add(man7);
            VehicleManufacturer man8 = new VehicleManufacturer() { Type = 4, Name = "ביואל" };
            man8.Models = new List<VehicleModel>();
            man8.Models.Add(new VehicleModel() { Name = "1125CR הליקון" });
            man8.Models.Add(new VehicleModel() { Name = "1125R הליקון" });
            man8.Models.Add(new VehicleModel() { Name = "XB12CG לייטנינג" });
            man8.Models.Add(new VehicleModel() { Name = "XB12R פיירבולט" });
            man8.Models.Add(new VehicleModel() { Name = "XB12S לייטנינג" });
            man8.Models.Add(new VehicleModel() { Name = "XB12SS לייטנינג לונג" });
            man8.Models.Add(new VehicleModel() { Name = "XB12STT סופר" });
            man8.Models.Add(new VehicleModel() { Name = "XB12X יוליסס" });
            man8.Models.Add(new VehicleModel() { Name = "XB12XT יוליסס" });
            man8.Models.Add(new VehicleModel() { Name = "XB9SX לייטנינג" });
            man8.Models.Add(new VehicleModel() { Name = "אחר" });
            mans.Add(man8);
            VehicleManufacturer man9 = new VehicleManufacturer() { Type = 4, Name = "בנלי" };
            man9.Models = new List<VehicleModel>();
            man9.Models.Add(new VehicleModel() { Name = "אדיבה 125" });
            man9.Models.Add(new VehicleModel() { Name = "אדיבה 150" });
            man9.Models.Add(new VehicleModel() { Name = "אחר" });
            mans.Add(man9);
            VehicleManufacturer man10 = new VehicleManufacturer() { Type = 4, Name = "ג'אווה" };
            man10.Models = new List<VehicleModel>();
            man10.Models.Add(new VehicleModel() { Name = "350" });
            man10.Models.Add(new VehicleModel() { Name = "אחר" });
            mans.Add(man10);
            VehicleManufacturer man11 = new VehicleManufacturer() { Type = 4, Name = "גאס-גאס" };
            man11.Models = new List<VehicleModel>();
            man11.Models.Add(new VehicleModel() { Name = "EC 250 4T" });
            man11.Models.Add(new VehicleModel() { Name = "TXT" });
            mans.Add(man11);
            VehicleManufacturer man12 = new VehicleManufacturer() { Type = 4, Name = "דוקאטי" };
            man12.Models = new List<VehicleModel>();
            man12.Models.Add(new VehicleModel() { Name = "1098" });
            man12.Models.Add(new VehicleModel() { Name = "1098R" });
            man12.Models.Add(new VehicleModel() { Name = "1098S" });
            man12.Models.Add(new VehicleModel() { Name = "1198" });
            man12.Models.Add(new VehicleModel() { Name = "1198R" });
            man12.Models.Add(new VehicleModel() { Name = "1198R קורסה" });
            man12.Models.Add(new VehicleModel() { Name = "1198S" });
            man12.Models.Add(new VehicleModel() { Name = "1198S קורסה" });
            man12.Models.Add(new VehicleModel() { Name = "1198SP" });
            man12.Models.Add(new VehicleModel() { Name = "620SS" });
            man12.Models.Add(new VehicleModel() { Name = "748/749" });
            man12.Models.Add(new VehicleModel() { Name = "800SS" });
            man12.Models.Add(new VehicleModel() { Name = "848" });
            man12.Models.Add(new VehicleModel() { Name = "848 EVO" });
            man12.Models.Add(new VehicleModel() { Name = "848 EVO דארק" });
            man12.Models.Add(new VehicleModel() { Name = "848 דארק" });
            man12.Models.Add(new VehicleModel() { Name = "900/1000SS" });
            man12.Models.Add(new VehicleModel() { Name = "999" });
            man12.Models.Add(new VehicleModel() { Name = "GT1000" });
            man12.Models.Add(new VehicleModel() { Name = "GT1000 ביקולור" });
            man12.Models.Add(new VehicleModel() { Name = "GT1000 טורינג" });
            man12.Models.Add(new VehicleModel() { Name = "ST3" });
            man12.Models.Add(new VehicleModel() { Name = "דיאבל" });
            man12.Models.Add(new VehicleModel() { Name = "היפרמוטרד 1100" });
            man12.Models.Add(new VehicleModel() { Name = "היפרמוטרד 1100 EVO" });
            man12.Models.Add(new VehicleModel() { Name = "היפרמוטרד 1100 EVO SP" });
            man12.Models.Add(new VehicleModel() { Name = "היפרמוטרד 1100S" });
            man12.Models.Add(new VehicleModel() { Name = "היפרמוטרד 796 מבריק" });
            man12.Models.Add(new VehicleModel() { Name = "היפרמוטרד 796 מט" });
            man12.Models.Add(new VehicleModel() { Name = "מולטיסטרדה 1000" });
            man12.Models.Add(new VehicleModel() { Name = "מולטיסטרדה 1100" });
            man12.Models.Add(new VehicleModel() { Name = "מולטיסטרדה 1100S" });
            man12.Models.Add(new VehicleModel() { Name = "מולטיסטרדה 1200" });
            man12.Models.Add(new VehicleModel() { Name = "מולטיסטרדה 1200S" });
            man12.Models.Add(new VehicleModel() { Name = "מולטיסטרדה 1200T" });
            man12.Models.Add(new VehicleModel() { Name = "מולטיסטרדה 620" });
            man12.Models.Add(new VehicleModel() { Name = "מונסטר 1100" });
            man12.Models.Add(new VehicleModel() { Name = "מונסטר 1100 EVO" });
            man12.Models.Add(new VehicleModel() { Name = "מונסטר 1100S" });
            man12.Models.Add(new VehicleModel() { Name = "מונסטר 620 דארק" });
            man12.Models.Add(new VehicleModel() { Name = "מונסטר 620ie" });
            man12.Models.Add(new VehicleModel() { Name = "מונסטר 695" });
            man12.Models.Add(new VehicleModel() { Name = "מונסטר 696" });
            man12.Models.Add(new VehicleModel() { Name = "מונסטר 796" });
            man12.Models.Add(new VehicleModel() { Name = "מונסטר 900/1000DS" });
            man12.Models.Add(new VehicleModel() { Name = "מונסטר S2R1000" });
            man12.Models.Add(new VehicleModel() { Name = "מונסטר S2R800" });
            man12.Models.Add(new VehicleModel() { Name = "מונסטר S4R" });
            man12.Models.Add(new VehicleModel() { Name = "מונסטר S4RS" });
            man12.Models.Add(new VehicleModel() { Name = "סטריטפייטר" });
            man12.Models.Add(new VehicleModel() { Name = "סטריטפייטר S" });
            man12.Models.Add(new VehicleModel() { Name = "ספורט 1000S" });
            man12.Models.Add(new VehicleModel() { Name = "טרנזיט" });
            mans.Add(man12);
            VehicleManufacturer man13 = new VehicleManufacturer() { Type = 4, Name = "דיאלים" };
            man13.Models = new List<VehicleModel>();
            man13.Models.Add(new VehicleModel() { Name = "Roadwin 125" });
            man13.Models.Add(new VehicleModel() { Name = "Roadwin 250" });
            man13.Models.Add(new VehicleModel() { Name = "VL Day Star 250" });
            man13.Models.Add(new VehicleModel() { Name = "אחר" });
            mans.Add(man13);
            VehicleManufacturer man14 = new VehicleManufacturer() { Type = 4, Name = "דרבי" };
            man14.Models = new List<VehicleModel>();
            man14.Models.Add(new VehicleModel() { Name = "GPR" });
            man14.Models.Add(new VehicleModel() { Name = "סנדה" });
            man14.Models.Add(new VehicleModel() { Name = "סנדרה" });
            man14.Models.Add(new VehicleModel() { Name = "אחר" });
            mans.Add(man14);
            VehicleManufacturer man15 = new VehicleManufacturer() { Type = 4, Name = "הונדה" };
            man15.Models = new List<VehicleModel>();
            man15.Models.Add(new VehicleModel() { Name = "CB1000R" });
            man15.Models.Add(new VehicleModel() { Name = "CB250" });
            man15.Models.Add(new VehicleModel() { Name = "CB360E" });
            man15.Models.Add(new VehicleModel() { Name = "CB500S" });
            man15.Models.Add(new VehicleModel() { Name = "CBF1000ST" });
            man15.Models.Add(new VehicleModel() { Name = "CBF125M" });
            man15.Models.Add(new VehicleModel() { Name = "CBF250" });
            man15.Models.Add(new VehicleModel() { Name = "CBF500S" });
            man15.Models.Add(new VehicleModel() { Name = "CBF600S" });
            man15.Models.Add(new VehicleModel() { Name = "CBR1000RR" });
            man15.Models.Add(new VehicleModel() { Name = "CBR1100XX" });
            man15.Models.Add(new VehicleModel() { Name = "CBR125R" });
            man15.Models.Add(new VehicleModel() { Name = "CBR125RW" });
            man15.Models.Add(new VehicleModel() { Name = "CBR250R" });
            man15.Models.Add(new VehicleModel() { Name = "CBR500R" });
            man15.Models.Add(new VehicleModel() { Name = "CBR600 F5/FS/I" });
            man15.Models.Add(new VehicleModel() { Name = "CBR600RR" });
            man15.Models.Add(new VehicleModel() { Name = "CBR900/929/954RR" });
            man15.Models.Add(new VehicleModel() { Name = "CBX750" });
            man15.Models.Add(new VehicleModel() { Name = "CR" });
            man15.Models.Add(new VehicleModel() { Name = "CRF" });
            man15.Models.Add(new VehicleModel() { Name = "CRM 50" });
            man15.Models.Add(new VehicleModel() { Name = "CX500" });
            man15.Models.Add(new VehicleModel() { Name = "DN-01" });
            man15.Models.Add(new VehicleModel() { Name = "FMX650" });
            man15.Models.Add(new VehicleModel() { Name = "Forza NSS300" });
            man15.Models.Add(new VehicleModel() { Name = "GL1800 גולד-ווינג" });
            man15.Models.Add(new VehicleModel() { Name = "NC700X" });
            man15.Models.Add(new VehicleModel() { Name = "STX1300PE" });
            man15.Models.Add(new VehicleModel() { Name = "VFR1200F" });
            man15.Models.Add(new VehicleModel() { Name = "VFR750/800" });
            man15.Models.Add(new VehicleModel() { Name = "VT1100C" });
            man15.Models.Add(new VehicleModel() { Name = "VT125 שאדו" });
            man15.Models.Add(new VehicleModel() { Name = "VT1300CX פיורי" });
            man15.Models.Add(new VehicleModel() { Name = "VT600" });
            man15.Models.Add(new VehicleModel() { Name = "VT750C שאדו" });
            man15.Models.Add(new VehicleModel() { Name = "VT750S" });
            man15.Models.Add(new VehicleModel() { Name = "VTR1000 SP2" });
            man15.Models.Add(new VehicleModel() { Name = "VTR1000F" });
            man15.Models.Add(new VehicleModel() { Name = "VTX1800C" });
            man15.Models.Add(new VehicleModel() { Name = "XR125L" });
            man15.Models.Add(new VehicleModel() { Name = "XR250L" });
            man15.Models.Add(new VehicleModel() { Name = "XR600R" });
            man15.Models.Add(new VehicleModel() { Name = "XR650L" });
            man15.Models.Add(new VehicleModel() { Name = "XRV750 אפריקה טווין" });
            man15.Models.Add(new VehicleModel() { Name = "הורנט 600" });
            man15.Models.Add(new VehicleModel() { Name = "ואראדרו 1000" });
            man15.Models.Add(new VehicleModel() { Name = "ואראדרו 125" });
            man15.Models.Add(new VehicleModel() { Name = "טרנסאלפ 650" });
            man15.Models.Add(new VehicleModel() { Name = "טרנסאלפ 700" });
            man15.Models.Add(new VehicleModel() { Name = "קרוסראנר" });
            man15.Models.Add(new VehicleModel() { Name = "אחר" });
            mans.Add(man15);
            VehicleManufacturer man16 = new VehicleManufacturer() { Type = 4, Name = "הוסאברג" };
            man16.Models = new List<VehicleModel>();
            man16.Models.Add(new VehicleModel() { Name = "FE 390" });
            man16.Models.Add(new VehicleModel() { Name = "FE 450" });
            man16.Models.Add(new VehicleModel() { Name = "FE 570" });
            man16.Models.Add(new VehicleModel() { Name = "FS 570" });
            man16.Models.Add(new VehicleModel() { Name = "TE 125" });
            man16.Models.Add(new VehicleModel() { Name = "TE 250" });
            man16.Models.Add(new VehicleModel() { Name = "TE 300" });
            man16.Models.Add(new VehicleModel() { Name = "אחר" });
            mans.Add(man16);
            VehicleManufacturer man17 = new VehicleManufacturer() { Type = 4, Name = "הוסקוורנה" };
            man17.Models = new List<VehicleModel>();
            man17.Models.Add(new VehicleModel() { Name = "NUDA900R" });
            man17.Models.Add(new VehicleModel() { Name = "SM125S" });
            man17.Models.Add(new VehicleModel() { Name = "SM450R" });
            man17.Models.Add(new VehicleModel() { Name = "SM510R" });
            man17.Models.Add(new VehicleModel() { Name = "SM610iE" });
            man17.Models.Add(new VehicleModel() { Name = "SM630S" });
            man17.Models.Add(new VehicleModel() { Name = "TE125" });
            man17.Models.Add(new VehicleModel() { Name = "TE250" });
            man17.Models.Add(new VehicleModel() { Name = "TE310" });
            man17.Models.Add(new VehicleModel() { Name = "TE350" });
            man17.Models.Add(new VehicleModel() { Name = "TE449" });
            man17.Models.Add(new VehicleModel() { Name = "TE450" });
            man17.Models.Add(new VehicleModel() { Name = "TE510" });
            man17.Models.Add(new VehicleModel() { Name = "TE511" });
            man17.Models.Add(new VehicleModel() { Name = "TE610iE" });
            man17.Models.Add(new VehicleModel() { Name = "TE630" });
            man17.Models.Add(new VehicleModel() { Name = "WR125" });
            man17.Models.Add(new VehicleModel() { Name = "WR250" });
            man17.Models.Add(new VehicleModel() { Name = "WR300" });
            man17.Models.Add(new VehicleModel() { Name = "WR360" });
            man17.Models.Add(new VehicleModel() { Name = "אחר" });
            mans.Add(man17);
            VehicleManufacturer man18 = new VehicleManufacturer() { Type = 4, Name = "הרלי דיווידסון" };
            man18.Models = new List<VehicleModel>();
            man18.Models.Add(new VehicleModel() { Name = "Street-Rod 1130" });
            man18.Models.Add(new VehicleModel() { Name = "V-Rod 1130" });
            man18.Models.Add(new VehicleModel() { Name = "XR1200R" });
            man18.Models.Add(new VehicleModel() { Name = "אלקטרה גלייד 1340" });
            man18.Models.Add(new VehicleModel() { Name = "אלקטרה גלייד 1450" });
            man18.Models.Add(new VehicleModel() { Name = "אלקטרה גלייד 1585" });
            man18.Models.Add(new VehicleModel() { Name = "אלקטרה גלייד סטנדרט 1450" });
            man18.Models.Add(new VehicleModel() { Name = "אלקטרה גלייד סטנדרט 1585" });
            man18.Models.Add(new VehicleModel() { Name = "דיינה לוו-ריידר 1340" });
            man18.Models.Add(new VehicleModel() { Name = "דיינה לוו-ריידר 1450" });
            man18.Models.Add(new VehicleModel() { Name = "דיינה לוו-ריידר 1585" });
            man18.Models.Add(new VehicleModel() { Name = "דיינה סופר-גלייד 1340" });
            man18.Models.Add(new VehicleModel() { Name = "דיינה סופר-גלייד 1450" });
            man18.Models.Add(new VehicleModel() { Name = "דיינה סופר-גלייד קאסטום 1450" });
            man18.Models.Add(new VehicleModel() { Name = "דיינה סופר-גלייד קאסטום 1585" });
            man18.Models.Add(new VehicleModel() { Name = "דיינה סטריט בוב 1585" });
            man18.Models.Add(new VehicleModel() { Name = "דיינה פאט בוב 1585" });
            man18.Models.Add(new VehicleModel() { Name = "סופטייל דיוס 1340" });
            man18.Models.Add(new VehicleModel() { Name = "סופטייל דיוס 1450" });
            man18.Models.Add(new VehicleModel() { Name = "סופטייל דלוקס 1450" });
            man18.Models.Add(new VehicleModel() { Name = "סופטייל דלוקס 1585" });
            man18.Models.Add(new VehicleModel() { Name = "סופטייל הריטג' 1340" });
            man18.Models.Add(new VehicleModel() { Name = "סופטייל הריטג' 1450" });
            man18.Models.Add(new VehicleModel() { Name = "סופטייל הריטג' 1585" });
            man18.Models.Add(new VehicleModel() { Name = "סופטייל נייט טריין 1340" });
            man18.Models.Add(new VehicleModel() { Name = "סופטייל נייט טריין 1450" });
            man18.Models.Add(new VehicleModel() { Name = "סופטייל נייט טריין 1585" });
            man18.Models.Add(new VehicleModel() { Name = "סופטייל סטנדרט 1450" });
            man18.Models.Add(new VehicleModel() { Name = "סופטייל פאט-בוי 1340" });
            man18.Models.Add(new VehicleModel() { Name = "סופטייל פאט-בוי 1450" });
            man18.Models.Add(new VehicleModel() { Name = "סופטייל פאט-בוי 1585" });
            man18.Models.Add(new VehicleModel() { Name = "סופטייל קאסטום 1585" });
            man18.Models.Add(new VehicleModel() { Name = "סופטייל קרוס-בונס 1585" });
            man18.Models.Add(new VehicleModel() { Name = "סופטייל רוקר 1585" });
            man18.Models.Add(new VehicleModel() { Name = "ספורטסטר 1200C" });
            man18.Models.Add(new VehicleModel() { Name = "ספורטסטר 1200R" });
            man18.Models.Add(new VehicleModel() { Name = "ספורטסטר 883" });
            man18.Models.Add(new VehicleModel() { Name = "ספורטסטר 883C" });
            man18.Models.Add(new VehicleModel() { Name = "רואד-קינג 1340" });
            man18.Models.Add(new VehicleModel() { Name = "רואד-קינג 1450" });
            man18.Models.Add(new VehicleModel() { Name = "רואד-קינג 1585" });
            man18.Models.Add(new VehicleModel() { Name = "אחר" });
            mans.Add(man18);
            VehicleManufacturer man19 = new VehicleManufacturer() { Type = 4, Name = "זונגשן" };
            man19.Models = new List<VehicleModel>();
            man19.Models.Add(new VehicleModel() { Name = "ZS-250-5" });
            man19.Models.Add(new VehicleModel() { Name = "ZS125-ZY" });
            man19.Models.Add(new VehicleModel() { Name = "ZS200-GY-2" });
            man19.Models.Add(new VehicleModel() { Name = "ZS250GS" });
            man19.Models.Add(new VehicleModel() { Name = "אחר" });
            mans.Add(man19);
            VehicleManufacturer man20 = new VehicleManufacturer() { Type = 4, Name = "טריומף" };
            man20.Models = new List<VehicleModel>();
            man20.Models.Add(new VehicleModel() { Name = "דייטונה" });
            man20.Models.Add(new VehicleModel() { Name = "אחר" });
            mans.Add(man20);
            VehicleManufacturer man21 = new VehicleManufacturer() { Type = 4, Name = "יאווה" };
            man21.Models = new List<VehicleModel>();
            man21.Models.Add(new VehicleModel() { Name = "638" });
            man21.Models.Add(new VehicleModel() { Name = "640" });
            mans.Add(man21);
            VehicleManufacturer man22 = new VehicleManufacturer() { Type = 4, Name = "יוסאנג" };
            man22.Models = new List<VehicleModel>();
            man22.Models.Add(new VehicleModel() { Name = "GT125 קומט" });
            man22.Models.Add(new VehicleModel() { Name = "GT125R קומט" });
            man22.Models.Add(new VehicleModel() { Name = "GT250 קומט" });
            man22.Models.Add(new VehicleModel() { Name = "GT250R קומט" });
            man22.Models.Add(new VehicleModel() { Name = "GT650 קומט" });
            man22.Models.Add(new VehicleModel() { Name = "GT650R קומט" });
            man22.Models.Add(new VehicleModel() { Name = "GT650S קומט" });
            man22.Models.Add(new VehicleModel() { Name = "GV125" });
            man22.Models.Add(new VehicleModel() { Name = "GV250 אקילה" });
            man22.Models.Add(new VehicleModel() { Name = "GV650 אקילה" });
            man22.Models.Add(new VehicleModel() { Name = "RX125D" });
            man22.Models.Add(new VehicleModel() { Name = "RX125SM" });
            man22.Models.Add(new VehicleModel() { Name = "אחר" });
            mans.Add(man22);
            VehicleManufacturer man23 = new VehicleManufacturer() { Type = 4, Name = "ימאהה" };
            man23.Models = new List<VehicleModel>();
            man23.Models.Add(new VehicleModel() { Name = "BT1100 בולדוג" });
            man23.Models.Add(new VehicleModel() { Name = "DT50/SM" });
            man23.Models.Add(new VehicleModel() { Name = "FJR1300" });
            man23.Models.Add(new VehicleModel() { Name = "FZ1 פייזר" });
            man23.Models.Add(new VehicleModel() { Name = "FZ1N" });
            man23.Models.Add(new VehicleModel() { Name = "FZ6S פייזר" });
            man23.Models.Add(new VehicleModel() { Name = "FZ8" });
            man23.Models.Add(new VehicleModel() { Name = "FZR1000" });
            man23.Models.Add(new VehicleModel() { Name = "FZR600R" });
            man23.Models.Add(new VehicleModel() { Name = "MT-01" });
            man23.Models.Add(new VehicleModel() { Name = "TDM850/900" });
            man23.Models.Add(new VehicleModel() { Name = "TT600" });
            man23.Models.Add(new VehicleModel() { Name = "TT600E" });
            man23.Models.Add(new VehicleModel() { Name = "TT600R" });
            man23.Models.Add(new VehicleModel() { Name = "TT600S" });
            man23.Models.Add(new VehicleModel() { Name = "TW200" });
            man23.Models.Add(new VehicleModel() { Name = "V-Max 1200" });
            man23.Models.Add(new VehicleModel() { Name = "V-Max 1700" });
            man23.Models.Add(new VehicleModel() { Name = "WR125R" });
            man23.Models.Add(new VehicleModel() { Name = "WR125X" });
            man23.Models.Add(new VehicleModel() { Name = "WR250F" });
            man23.Models.Add(new VehicleModel() { Name = "WR250R" });
            man23.Models.Add(new VehicleModel() { Name = "WR250X" });
            man23.Models.Add(new VehicleModel() { Name = "WR400/426/450F" });
            man23.Models.Add(new VehicleModel() { Name = "XJ400 דיוורז'ן" });
            man23.Models.Add(new VehicleModel() { Name = "XJ6 דיוורז\"ן" });
            man23.Models.Add(new VehicleModel() { Name = "XJ600 דיוורז'ן" });
            man23.Models.Add(new VehicleModel() { Name = "XJ6N" });
            man23.Models.Add(new VehicleModel() { Name = "XT1200Z סופר טנרה" });
            man23.Models.Add(new VehicleModel() { Name = "XT125R" });
            man23.Models.Add(new VehicleModel() { Name = "XT125X" });
            man23.Models.Add(new VehicleModel() { Name = "XT350" });
            man23.Models.Add(new VehicleModel() { Name = "XT500" });
            man23.Models.Add(new VehicleModel() { Name = "XT600E" });
            man23.Models.Add(new VehicleModel() { Name = "XT660R" });
            man23.Models.Add(new VehicleModel() { Name = "XT660Z טנרה" });
            man23.Models.Add(new VehicleModel() { Name = "XTZ660 טנרה" });
            man23.Models.Add(new VehicleModel() { Name = "XTZ750 סופר-טנרה" });
            man23.Models.Add(new VehicleModel() { Name = "XV1900 מידנייט-סטאר" });
            man23.Models.Add(new VehicleModel() { Name = "XVS1100 דראג-סטאר" });
            man23.Models.Add(new VehicleModel() { Name = "XVS1300 קלאסיק" });
            man23.Models.Add(new VehicleModel() { Name = "XVS650 דראג-סטאר" });
            man23.Models.Add(new VehicleModel() { Name = "YBR250" });
            man23.Models.Add(new VehicleModel() { Name = "YZ" });
            man23.Models.Add(new VehicleModel() { Name = "YZF-R1" });
            man23.Models.Add(new VehicleModel() { Name = "YZF-R125" });
            man23.Models.Add(new VehicleModel() { Name = "YZF-R6" });
            man23.Models.Add(new VehicleModel() { Name = "YZF-R6R" });
            man23.Models.Add(new VehicleModel() { Name = "YZF1000R ת'אנדראייס" });
            man23.Models.Add(new VehicleModel() { Name = "YZF250" });
            man23.Models.Add(new VehicleModel() { Name = "YZF600R ת'אנדרקאט" });
            man23.Models.Add(new VehicleModel() { Name = "ויראגו 250" });
            man23.Models.Add(new VehicleModel() { Name = "ויראגו 500" });
            man23.Models.Add(new VehicleModel() { Name = "ויראגו 750" });
            man23.Models.Add(new VehicleModel() { Name = "טריקר 250" });
            man23.Models.Add(new VehicleModel() { Name = "פייזר 1000" });
            man23.Models.Add(new VehicleModel() { Name = "פייזר 600" });
            man23.Models.Add(new VehicleModel() { Name = "פייזר 8" });
            man23.Models.Add(new VehicleModel() { Name = "אחר" });
            mans.Add(man23);
            VehicleManufacturer man24 = new VehicleManufacturer() { Type = 4, Name = "ליפאן" };
            man24.Models = new List<VehicleModel>();
            man24.Models.Add(new VehicleModel() { Name = "LFT" });
            man24.Models.Add(new VehicleModel() { Name = "אחר" });
            mans.Add(man24);
            VehicleManufacturer man25 = new VehicleManufacturer() { Type = 4, Name = "למברטה" };
            mans.Add(man25);
            VehicleManufacturer man26 = new VehicleManufacturer() { Type = 4, Name = "מוטוגוצי" };
            man26.Models = new List<VehicleModel>();
            man26.Models.Add(new VehicleModel() { Name = "TT" });
            man26.Models.Add(new VehicleModel() { Name = "קליפורניה" });
            man26.Models.Add(new VehicleModel() { Name = "אחר" });
            mans.Add(man26);
            VehicleManufacturer man27 = new VehicleManufacturer() { Type = 4, Name = "מוטומוריני" };
            man27.Models = new List<VehicleModel>();
            man27.Models.Add(new VehicleModel() { Name = "501" });
            man27.Models.Add(new VehicleModel() { Name = "אחר" });
            mans.Add(man27);
            VehicleManufacturer man28 = new VehicleManufacturer() { Type = 4, Name = "מיני בייק" };
            man28.Models = new List<VehicleModel>();
            man28.Models.Add(new VehicleModel() { Name = "כללי" });
            mans.Add(man28);
            VehicleManufacturer man29 = new VehicleManufacturer() { Type = 4, Name = "סוזוקי" };
            man29.Models = new List<VehicleModel>();
            man29.Models.Add(new VehicleModel() { Name = "2" });
            man29.Models.Add(new VehicleModel() { Name = "C800 אינטרודר" });
            man29.Models.Add(new VehicleModel() { Name = "DL1000 וי-סטרום" });
            man29.Models.Add(new VehicleModel() { Name = "DL650 וי-סטרום" });
            man29.Models.Add(new VehicleModel() { Name = "DL650A וי-סטרום" });
            man29.Models.Add(new VehicleModel() { Name = "DL650GT וי-סטרום" });
            man29.Models.Add(new VehicleModel() { Name = "DR BIG 800" });
            man29.Models.Add(new VehicleModel() { Name = "DR350" });
            man29.Models.Add(new VehicleModel() { Name = "DR650R/RE/SE" });
            man29.Models.Add(new VehicleModel() { Name = "DR650RS/RSE" });
            man29.Models.Add(new VehicleModel() { Name = "DRZ125SM" });
            man29.Models.Add(new VehicleModel() { Name = "DRZ400S" });
            man29.Models.Add(new VehicleModel() { Name = "DRZ400SM" });
            man29.Models.Add(new VehicleModel() { Name = "GN250" });
            man29.Models.Add(new VehicleModel() { Name = "GS500E" });
            man29.Models.Add(new VehicleModel() { Name = "GS500F" });
            man29.Models.Add(new VehicleModel() { Name = "GSF1200 בנדיט" });
            man29.Models.Add(new VehicleModel() { Name = "GSF1250 בנדיט" });
            man29.Models.Add(new VehicleModel() { Name = "GSF1250S בנדיט" });
            man29.Models.Add(new VehicleModel() { Name = "GSR750" });
            man29.Models.Add(new VehicleModel() { Name = "GSX-R1000" });
            man29.Models.Add(new VehicleModel() { Name = "GSX-R1100" });
            man29.Models.Add(new VehicleModel() { Name = "GSX-R1300 בי-קינג" });
            man29.Models.Add(new VehicleModel() { Name = "GSX-R1300 היאבוסה" });
            man29.Models.Add(new VehicleModel() { Name = "GSX-R600" });
            man29.Models.Add(new VehicleModel() { Name = "GSX-R750" });
            man29.Models.Add(new VehicleModel() { Name = "GSX1100F" });
            man29.Models.Add(new VehicleModel() { Name = "GSX1250FA בנדיט" });
            man29.Models.Add(new VehicleModel() { Name = "GSX600F" });
            man29.Models.Add(new VehicleModel() { Name = "GSX750F" });
            man29.Models.Add(new VehicleModel() { Name = "GZ250" });
            man29.Models.Add(new VehicleModel() { Name = "M800 אינטרודר" });
            man29.Models.Add(new VehicleModel() { Name = "RF600" });
            man29.Models.Add(new VehicleModel() { Name = "RGV250" });
            man29.Models.Add(new VehicleModel() { Name = "RM" });
            man29.Models.Add(new VehicleModel() { Name = "RMX50" });
            man29.Models.Add(new VehicleModel() { Name = "RV125 ואן-ואן" });
            man29.Models.Add(new VehicleModel() { Name = "SFV650 גלדיוס" });
            man29.Models.Add(new VehicleModel() { Name = "SV1000S" });
            man29.Models.Add(new VehicleModel() { Name = "SV650N" });
            man29.Models.Add(new VehicleModel() { Name = "SV650S" });
            man29.Models.Add(new VehicleModel() { Name = "TL1000S" });
            man29.Models.Add(new VehicleModel() { Name = "TS50W" });
            man29.Models.Add(new VehicleModel() { Name = "TS50X" });
            man29.Models.Add(new VehicleModel() { Name = "TU250" });
            man29.Models.Add(new VehicleModel() { Name = "VX800" });
            man29.Models.Add(new VehicleModel() { Name = "אינטרודר 750" });
            man29.Models.Add(new VehicleModel() { Name = "בנדיט 400" });
            man29.Models.Add(new VehicleModel() { Name = "בנדיט 600" });
            man29.Models.Add(new VehicleModel() { Name = "וולף 50" });
            man29.Models.Add(new VehicleModel() { Name = "מרודר VZ800" });
            man29.Models.Add(new VehicleModel() { Name = "פריווינד XF650" });
            man29.Models.Add(new VehicleModel() { Name = "אחר" });
            mans.Add(man29);
            VehicleManufacturer man30 = new VehicleManufacturer() { Type = 4, Name = "סקיי-טים" };
            man30.Models = new List<VehicleModel>();
            man30.Models.Add(new VehicleModel() { Name = "Monkey / Gorilla" });
            man30.Models.Add(new VehicleModel() { Name = "T-Rex" });
            man30.Models.Add(new VehicleModel() { Name = "V-Raptor 125 / Ace 125" });
            man30.Models.Add(new VehicleModel() { Name = "V-Raptor 250" });
            mans.Add(man30);
            VehicleManufacturer man31 = new VehicleManufacturer() { Type = 4, Name = "פיאגו ריקשה" };
            man31.Models = new List<VehicleModel>();
            man31.Models.Add(new VehicleModel() { Name = "APE 220" });
            man31.Models.Add(new VehicleModel() { Name = "APE 400" });
            man31.Models.Add(new VehicleModel() { Name = "קרוס קאנטרי 50" });
            man31.Models.Add(new VehicleModel() { Name = "אחר" });
            mans.Add(man31);
            VehicleManufacturer man32 = new VehicleManufacturer() { Type = 4, Name = "פיג'ו" };
            man32.Models = new List<VehicleModel>();
            man32.Models.Add(new VehicleModel() { Name = "GMAX 125" });
            man32.Models.Add(new VehicleModel() { Name = "GMAX 250" });
            man32.Models.Add(new VehicleModel() { Name = "LIGERO" });
            man32.Models.Add(new VehicleModel() { Name = "T-REX" });
            man32.Models.Add(new VehicleModel() { Name = "כללי" });
            mans.Add(man32);
            VehicleManufacturer man33 = new VehicleManufacturer() { Type = 4, Name = "ק.ט.מ" };
            man33.Models = new List<VehicleModel>();
            man33.Models.Add(new VehicleModel() { Name = "250 EXC-F" });
            man33.Models.Add(new VehicleModel() { Name = "300 EXC-E" });
            man33.Models.Add(new VehicleModel() { Name = "400 EGS-E" });
            man33.Models.Add(new VehicleModel() { Name = "400 SC/SXC" });
            man33.Models.Add(new VehicleModel() { Name = "450 SMR" });
            man33.Models.Add(new VehicleModel() { Name = "50 SX" });
            man33.Models.Add(new VehicleModel() { Name = "530 EXC-R" });
            man33.Models.Add(new VehicleModel() { Name = "620 EGS" });
            man33.Models.Add(new VehicleModel() { Name = "620 SC" });
            man33.Models.Add(new VehicleModel() { Name = "690 אנדורו" });
            man33.Models.Add(new VehicleModel() { Name = "690R אנדורו" });
            man33.Models.Add(new VehicleModel() { Name = "950 סופר אנדורו" });
            man33.Models.Add(new VehicleModel() { Name = "990 אדוונצ\"ר" });
            man33.Models.Add(new VehicleModel() { Name = "990 אדוונצ'ר ABS דקאר" });
            man33.Models.Add(new VehicleModel() { Name = "990 סופר-דיוק" });
            man33.Models.Add(new VehicleModel() { Name = "EGS 400" });
            man33.Models.Add(new VehicleModel() { Name = "EXC 125" });
            man33.Models.Add(new VehicleModel() { Name = "EXC 200" });
            man33.Models.Add(new VehicleModel() { Name = "EXC 250" });
            man33.Models.Add(new VehicleModel() { Name = "EXC 250 רייסינג T4" });
            man33.Models.Add(new VehicleModel() { Name = "EXC 300" });
            man33.Models.Add(new VehicleModel() { Name = "EXC 360/380" });
            man33.Models.Add(new VehicleModel() { Name = "EXC 400 פקטורי" });
            man33.Models.Add(new VehicleModel() { Name = "EXC 400 רייסינג" });
            man33.Models.Add(new VehicleModel() { Name = "EXC 450 פקטורי" });
            man33.Models.Add(new VehicleModel() { Name = "EXC 450 רייסינג" });
            man33.Models.Add(new VehicleModel() { Name = "EXC 50" });
            man33.Models.Add(new VehicleModel() { Name = "EXC 520/525 רייסינג" });
            man33.Models.Add(new VehicleModel() { Name = "EXC 525 פקטורי רייסינג" });
            man33.Models.Add(new VehicleModel() { Name = "EXC-F 350" });
            man33.Models.Add(new VehicleModel() { Name = "EXC-R400" });
            man33.Models.Add(new VehicleModel() { Name = "Freeride 350" });
            man33.Models.Add(new VehicleModel() { Name = "LC8-990" });
            man33.Models.Add(new VehicleModel() { Name = "RC8-1190" });
            man33.Models.Add(new VehicleModel() { Name = "RC8-1190R" });
            man33.Models.Add(new VehicleModel() { Name = "SM640" });
            man33.Models.Add(new VehicleModel() { Name = "SM690" });
            man33.Models.Add(new VehicleModel() { Name = "SM950" });
            man33.Models.Add(new VehicleModel() { Name = "SM990" });
            man33.Models.Add(new VehicleModel() { Name = "SMC690" });
            man33.Models.Add(new VehicleModel() { Name = "SMR690" });
            man33.Models.Add(new VehicleModel() { Name = "SMR990" });
            man33.Models.Add(new VehicleModel() { Name = "SMT990" });
            man33.Models.Add(new VehicleModel() { Name = "אדוונצ\"ר 950" });
            man33.Models.Add(new VehicleModel() { Name = "אדוונצ'ר 640" });
            man33.Models.Add(new VehicleModel() { Name = "אדוונצ'ר 950/990S" });
            man33.Models.Add(new VehicleModel() { Name = "אנדורו 640" });
            man33.Models.Add(new VehicleModel() { Name = "דיוק 125" });
            man33.Models.Add(new VehicleModel() { Name = "דיוק 640" });
            man33.Models.Add(new VehicleModel() { Name = "דיוק 690" });
            man33.Models.Add(new VehicleModel() { Name = "דיוק 690R" });
            man33.Models.Add(new VehicleModel() { Name = "סופר-דיוק 990R" });
            man33.Models.Add(new VehicleModel() { Name = "אחר" });
            mans.Add(man33);
            VehicleManufacturer man34 = new VehicleManufacturer() { Type = 4, Name = "קאג'יבה" };
            man34.Models = new List<VehicleModel>();
            man34.Models.Add(new VehicleModel() { Name = "כללי" });
            mans.Add(man34);
            VehicleManufacturer man35 = new VehicleManufacturer() { Type = 4, Name = "קאוואסאקי" };
            man35.Models = new List<VehicleModel>();
            man35.Models.Add(new VehicleModel() { Name = "EN500" });
            man35.Models.Add(new VehicleModel() { Name = "ER-5" });
            man35.Models.Add(new VehicleModel() { Name = "ER-6F" });
            man35.Models.Add(new VehicleModel() { Name = "ER-6N" });
            man35.Models.Add(new VehicleModel() { Name = "GPX250" });
            man35.Models.Add(new VehicleModel() { Name = "GPZ500" });
            man35.Models.Add(new VehicleModel() { Name = "GTR1400" });
            man35.Models.Add(new VehicleModel() { Name = "KLE500" });
            man35.Models.Add(new VehicleModel() { Name = "KLR250" });
            man35.Models.Add(new VehicleModel() { Name = "KLR600" });
            man35.Models.Add(new VehicleModel() { Name = "KLR650" });
            man35.Models.Add(new VehicleModel() { Name = "KLX125" });
            man35.Models.Add(new VehicleModel() { Name = "KLX140" });
            man35.Models.Add(new VehicleModel() { Name = "KLX250R" });
            man35.Models.Add(new VehicleModel() { Name = "KLX250S" });
            man35.Models.Add(new VehicleModel() { Name = "KLX450R" });
            man35.Models.Add(new VehicleModel() { Name = "KLX650C" });
            man35.Models.Add(new VehicleModel() { Name = "KLX650R" });
            man35.Models.Add(new VehicleModel() { Name = "KX" });
            man35.Models.Add(new VehicleModel() { Name = "Versys 650" });
            man35.Models.Add(new VehicleModel() { Name = "VN1500" });
            man35.Models.Add(new VehicleModel() { Name = "VN1600" });
            man35.Models.Add(new VehicleModel() { Name = "VN1700 וויאג'ר" });
            man35.Models.Add(new VehicleModel() { Name = "VN2000" });
            man35.Models.Add(new VehicleModel() { Name = "VN800 קלאסיק" });
            man35.Models.Add(new VehicleModel() { Name = "VN900 קלאסיק" });
            man35.Models.Add(new VehicleModel() { Name = "W800" });
            man35.Models.Add(new VehicleModel() { Name = "Z1000" });
            man35.Models.Add(new VehicleModel() { Name = "Z1000SX" });
            man35.Models.Add(new VehicleModel() { Name = "Z750L" });
            man35.Models.Add(new VehicleModel() { Name = "Z750R" });
            man35.Models.Add(new VehicleModel() { Name = "Z750S" });
            man35.Models.Add(new VehicleModel() { Name = "Z800R" });
            man35.Models.Add(new VehicleModel() { Name = "ZX-10R Ninja" });
            man35.Models.Add(new VehicleModel() { Name = "ZX-12R" });
            man35.Models.Add(new VehicleModel() { Name = "ZX-636R/6R" });
            man35.Models.Add(new VehicleModel() { Name = "ZX-6R" });
            man35.Models.Add(new VehicleModel() { Name = "ZX-7R" });
            man35.Models.Add(new VehicleModel() { Name = "ZX-9R" });
            man35.Models.Add(new VehicleModel() { Name = "ZZR1100/1200" });
            man35.Models.Add(new VehicleModel() { Name = "ZZR1400" });
            man35.Models.Add(new VehicleModel() { Name = "ZZR600" });
            man35.Models.Add(new VehicleModel() { Name = "נינג'ה 250R" });
            man35.Models.Add(new VehicleModel() { Name = "נינג'ה 300" });
            man35.Models.Add(new VehicleModel() { Name = "אחר" });
            mans.Add(man35);
            VehicleManufacturer man36 = new VehicleManufacturer() { Type = 4, Name = "קיוואי" };
            man36.Models = new List<VehicleModel>();
            man36.Models.Add(new VehicleModel() { Name = "ARN 125/RX" });
            man36.Models.Add(new VehicleModel() { Name = "F-ACT 125" });
            man36.Models.Add(new VehicleModel() { Name = "MATRIX 125" });
            man36.Models.Add(new VehicleModel() { Name = "הוריקן 50" });
            man36.Models.Add(new VehicleModel() { Name = "הוריקן 90" });
            man36.Models.Add(new VehicleModel() { Name = "לנד קרוזר 250" });
            man36.Models.Add(new VehicleModel() { Name = "סופרלייט 125" });
            man36.Models.Add(new VehicleModel() { Name = "סופרשאדו 250" });
            man36.Models.Add(new VehicleModel() { Name = "ספיד 125" });
            man36.Models.Add(new VehicleModel() { Name = "אחר" });
            mans.Add(man36);
            VehicleManufacturer man37 = new VehicleManufacturer() { Type = 4, Name = "קימקו" };
            man37.Models = new List<VehicleModel>();
            man37.Models.Add(new VehicleModel() { Name = "אחר" });
            man37.Models.Add(new VehicleModel() { Name = "קוואנון 125" });
            mans.Add(man37);
            VehicleManufacturer man38 = new VehicleManufacturer() { Type = 4, Name = "קליבלנד" };
            man38.Models = new List<VehicleModel>();
            man38.Models.Add(new VehicleModel() { Name = "tha heist 125" });
            man38.Models.Add(new VehicleModel() { Name = "tha heist 250" });
            mans.Add(man38);
            VehicleManufacturer man39 = new VehicleManufacturer() { Type = 4, Name = "קסינג-יו" };
            man39.Models = new List<VehicleModel>();
            man39.Models.Add(new VehicleModel() { Name = "XY400-2" });
            mans.Add(man39);
            VehicleManufacturer man40 = new VehicleManufacturer() { Type = 4, Name = "רויאל אנפילד" };
            man40.Models = new List<VehicleModel>();
            man40.Models.Add(new VehicleModel() { Name = "אחר" });
            man40.Models.Add(new VehicleModel() { Name = "בולט אלקטרה EFI" });
            man40.Models.Add(new VehicleModel() { Name = "בולט אלקטרה דלוקס" });
            man40.Models.Add(new VehicleModel() { Name = "בולט קלאסיק" });
            man40.Models.Add(new VehicleModel() { Name = "בולט קלאסיק מיליטרי" });
            mans.Add(man40);
            VehicleManufacturer man41 = new VehicleManufacturer() { Type = 4, Name = "שרקו" };
            man41.Models = new List<VehicleModel>();
            man41.Models.Add(new VehicleModel() { Name = "SE-250R" });
            man41.Models.Add(new VehicleModel() { Name = "SE-300R" });
            man41.Models.Add(new VehicleModel() { Name = "SE-F300i Factory" });
            man41.Models.Add(new VehicleModel() { Name = "SE-F300iR" });
            man41.Models.Add(new VehicleModel() { Name = "X-Ride 290" });
            mans.Add(man41);
            VehicleManufacturer man42 = new VehicleManufacturer() { Type = 4, Name = "אחר" };
            man42.Models = new List<VehicleModel>();
            man42.Models.Add(new VehicleModel() { Name = "כללי" });
            mans.Add(man42);
            VehicleManufacturer man43 = new VehicleManufacturer() { Type = 4, Name = "מחפש!" };
            man43.Models = new List<VehicleModel>();
            man43.Models.Add(new VehicleModel() { Name = "מחפש אופנוע" });
            mans.Add(man43);
            VehicleManufacturer man44 = new VehicleManufacturer() { Type = 5, Name = "CPI" };
            man44.Models = new List<VehicleModel>();
            man44.Models.Add(new VehicleModel() { Name = "אראגון 125" });
            man44.Models.Add(new VehicleModel() { Name = "הוסאר 125" });
            man44.Models.Add(new VehicleModel() { Name = "הוסאר 50" });
            man44.Models.Add(new VehicleModel() { Name = "מארס 50" });
            man44.Models.Add(new VehicleModel() { Name = "קינג 125" });
            man44.Models.Add(new VehicleModel() { Name = "אחר" });
            mans.Add(man44);
            VehicleManufacturer man45 = new VehicleManufacturer() { Type = 5, Name = "EVT" };
            man45.Models = new List<VehicleModel>();
            man45.Models.Add(new VehicleModel() { Name = "168 רטרו" });
            man45.Models.Add(new VehicleModel() { Name = "345 תלת" });
            man45.Models.Add(new VehicleModel() { Name = "E4000" });
            man45.Models.Add(new VehicleModel() { Name = "אחר" });
            mans.Add(man45);
            VehicleManufacturer man46 = new VehicleManufacturer() { Type = 5, Name = "FYM" };
            man46.Models = new List<VehicleModel>();
            man46.Models.Add(new VehicleModel() { Name = "125T-13" });
            man46.Models.Add(new VehicleModel() { Name = "125T-15" });
            man46.Models.Add(new VehicleModel() { Name = "125T-18" });
            man46.Models.Add(new VehicleModel() { Name = "150T-18" });
            man46.Models.Add(new VehicleModel() { Name = "אחר" });
            mans.Add(man46);
            VehicleManufacturer man47 = new VehicleManufacturer() { Type = 5, Name = "GMI" };
            man47.Models = new List<VehicleModel>();
            man47.Models.Add(new VehicleModel() { Name = "Runner" });
            mans.Add(man47);
            VehicleManufacturer man48 = new VehicleManufacturer() { Type = 5, Name = "LML Italia" };
            man48.Models = new List<VehicleModel>();
            man48.Models.Add(new VehicleModel() { Name = "STAR  DELUXE 125" });
            man48.Models.Add(new VehicleModel() { Name = "STAR  DELUXE 200" });
            man48.Models.Add(new VehicleModel() { Name = "STAR 2T 125" });
            man48.Models.Add(new VehicleModel() { Name = "STAR AUTOMATICA 125" });
            mans.Add(man48);
            VehicleManufacturer man49 = new VehicleManufacturer() { Type = 5, Name = "PGO" };
            man49.Models = new List<VehicleModel>();
            man49.Models.Add(new VehicleModel() { Name = "ג\"י-מקס 125" });
            man49.Models.Add(new VehicleModel() { Name = "ג'י-מקס 250" });
            man49.Models.Add(new VehicleModel() { Name = "טי-רקס 125" });
            man49.Models.Add(new VehicleModel() { Name = "ליגרו 125" });
            man49.Models.Add(new VehicleModel() { Name = "אחר" });
            mans.Add(man49);
            VehicleManufacturer man50 = new VehicleManufacturer() { Type = 5, Name = "TGB" };
            man50.Models = new List<VehicleModel>();
            man50.Models.Add(new VehicleModel() { Name = "R101 125" });
            man50.Models.Add(new VehicleModel() { Name = "R303 150" });
            man50.Models.Add(new VehicleModel() { Name = "R50X" });
            man50.Models.Add(new VehicleModel() { Name = "RS303 125" });
            man50.Models.Add(new VehicleModel() { Name = "T202 125" });
            man50.Models.Add(new VehicleModel() { Name = "X-Motion 125" });
            man50.Models.Add(new VehicleModel() { Name = "X-Motion 250" });
            man50.Models.Add(new VehicleModel() { Name = "X-Motion 300" });
            man50.Models.Add(new VehicleModel() { Name = "אקספרס 125" });
            man50.Models.Add(new VehicleModel() { Name = "אקרוס טק 50" });
            man50.Models.Add(new VehicleModel() { Name = "אראגון 50" });
            man50.Models.Add(new VehicleModel() { Name = "בולט 125" });
            man50.Models.Add(new VehicleModel() { Name = "דליברי 125" });
            man50.Models.Add(new VehicleModel() { Name = "דליברי 50" });
            man50.Models.Add(new VehicleModel() { Name = "הוק 125" });
            man50.Models.Add(new VehicleModel() { Name = "אחר" });
            mans.Add(man50);
            VehicleManufacturer man51 = new VehicleManufacturer() { Type = 5, Name = "אי-מקס" };
            man51.Models = new List<VehicleModel>();
            man51.Models.Add(new VehicleModel() { Name = "S110" });
            man51.Models.Add(new VehicleModel() { Name = "S90" });
            man51.Models.Add(new VehicleModel() { Name = "אחר" });
            mans.Add(man51);
            VehicleManufacturer man52 = new VehicleManufacturer() { Type = 5, Name = "אפריליה" };
            man52.Models = new List<VehicleModel>();
            man52.Models.Add(new VehicleModel() { Name = "AREA51" });
            man52.Models.Add(new VehicleModel() { Name = "RS50" });
            man52.Models.Add(new VehicleModel() { Name = "SR AC 50" });
            man52.Models.Add(new VehicleModel() { Name = "SR LC 50" });
            man52.Models.Add(new VehicleModel() { Name = "גוליבר 50" });
            man52.Models.Add(new VehicleModel() { Name = "לאונרדו 150" });
            man52.Models.Add(new VehicleModel() { Name = "סוניק 50" });
            man52.Models.Add(new VehicleModel() { Name = "סקראבאו 50" });
            man52.Models.Add(new VehicleModel() { Name = "ראלי AC 50" });
            man52.Models.Add(new VehicleModel() { Name = "ראלי LC 50" });
            man52.Models.Add(new VehicleModel() { Name = "אחר" });
            mans.Add(man52);
            VehicleManufacturer man53 = new VehicleManufacturer() { Type = 5, Name = "ב.מ.וו" };
            man53.Models = new List<VehicleModel>();
            man53.Models.Add(new VehicleModel() { Name = "C 600 ספורט" });
            man53.Models.Add(new VehicleModel() { Name = "C 650 GT" });
            man53.Models.Add(new VehicleModel() { Name = "C1 200" });
            man53.Models.Add(new VehicleModel() { Name = "אחר" });
            mans.Add(man53);
            VehicleManufacturer man54 = new VehicleManufacturer() { Type = 5, Name = "בטה" };
            man54.Models = new List<VehicleModel>();
            man54.Models.Add(new VehicleModel() { Name = "RR" });
            man54.Models.Add(new VehicleModel() { Name = "אלף" });
            man54.Models.Add(new VehicleModel() { Name = "ארק" });
            man54.Models.Add(new VehicleModel() { Name = "אחר" });
            mans.Add(man54);
            VehicleManufacturer man55 = new VehicleManufacturer() { Type = 5, Name = "בליץ מוטורס - קטנועים חשמליים" };
            man55.Models = new List<VehicleModel>();
            man55.Models.Add(new VehicleModel() { Name = "בליץ 3000" });
            man55.Models.Add(new VehicleModel() { Name = "בליץ-6000" });
            mans.Add(man55);
            VehicleManufacturer man56 = new VehicleManufacturer() { Type = 5, Name = "בנלי" };
            man56.Models = new List<VehicleModel>();
            man56.Models.Add(new VehicleModel() { Name = "אדיבה 125" });
            man56.Models.Add(new VehicleModel() { Name = "אדיבה 150" });
            man56.Models.Add(new VehicleModel() { Name = "כללי" });
            mans.Add(man56);
            VehicleManufacturer man57 = new VehicleManufacturer() { Type = 5, Name = "ג'ילרה" };
            man57.Models = new List<VehicleModel>();
            man57.Models.Add(new VehicleModel() { Name = "GP800" });
            man57.Models.Add(new VehicleModel() { Name = "ICE 50" });
            man57.Models.Add(new VehicleModel() { Name = "נקסוס 300" });
            man57.Models.Add(new VehicleModel() { Name = "נקסוס 500" });
            man57.Models.Add(new VehicleModel() { Name = "סטוקר 50" });
            man57.Models.Add(new VehicleModel() { Name = "פוקו 500" });
            man57.Models.Add(new VehicleModel() { Name = "ראנר 50" });
            man57.Models.Add(new VehicleModel() { Name = "ראנר VX125" });
            man57.Models.Add(new VehicleModel() { Name = "ראנר VXR180/200" });
            man57.Models.Add(new VehicleModel() { Name = "אחר" });
            mans.Add(man57);
            VehicleManufacturer man58 = new VehicleManufacturer() { Type = 5, Name = "דיאלים" };
            man58.Models = new List<VehicleModel>();
            man58.Models.Add(new VehicleModel() { Name = "B-bone 125" });
            man58.Models.Add(new VehicleModel() { Name = "S1 125" });
            man58.Models.Add(new VehicleModel() { Name = "S3 125" });
            man58.Models.Add(new VehicleModel() { Name = "S3 Advance 250" });
            man58.Models.Add(new VehicleModel() { Name = "ליברטי 50" });
            man58.Models.Add(new VehicleModel() { Name = "מסג' 50" });
            man58.Models.Add(new VehicleModel() { Name = "אחר" });
            mans.Add(man58);
            VehicleManufacturer man59 = new VehicleManufacturer() { Type = 5, Name = "דיבלאסי" };
            man59.Models = new List<VehicleModel>();
            man59.Models.Add(new VehicleModel() { Name = "אחר" });
            mans.Add(man59);
            VehicleManufacturer man60 = new VehicleManufacturer() { Type = 5, Name = "דרבי" };
            man60.Models = new List<VehicleModel>();
            man60.Models.Add(new VehicleModel() { Name = "GP1 50" });
            man60.Models.Add(new VehicleModel() { Name = "GPR50R" });
            man60.Models.Add(new VehicleModel() { Name = "אטלנטיס 50" });
            man60.Models.Add(new VehicleModel() { Name = "סנדה 50" });
            man60.Models.Add(new VehicleModel() { Name = "פרדטור 50" });
            man60.Models.Add(new VehicleModel() { Name = "קורייר/רבולושן 50" });
            man60.Models.Add(new VehicleModel() { Name = "רד-בוליט 50" });
            man60.Models.Add(new VehicleModel() { Name = "אחר" });
            mans.Add(man60);
            VehicleManufacturer man61 = new VehicleManufacturer() { Type = 5, Name = "הונדה" };
            man61.Models = new List<VehicleModel>();
            man61.Models.Add(new VehicleModel() { Name = "@125" });
            man61.Models.Add(new VehicleModel() { Name = "@150" });
            man61.Models.Add(new VehicleModel() { Name = "CH250" });
            man61.Models.Add(new VehicleModel() { Name = "CN250" });
            man61.Models.Add(new VehicleModel() { Name = "PCX 125" });
            man61.Models.Add(new VehicleModel() { Name = "PS125I" });
            man61.Models.Add(new VehicleModel() { Name = "PS150I" });
            man61.Models.Add(new VehicleModel() { Name = "S-Wing 125" });
            man61.Models.Add(new VehicleModel() { Name = "SH125" });
            man61.Models.Add(new VehicleModel() { Name = "SH125 דיסק" });
            man61.Models.Add(new VehicleModel() { Name = "SH150" });
            man61.Models.Add(new VehicleModel() { Name = "SH300I" });
            man61.Models.Add(new VehicleModel() { Name = "SH50" });
            man61.Models.Add(new VehicleModel() { Name = "SW400T" });
            man61.Models.Add(new VehicleModel() { Name = "X8RX/S 50" });
            man61.Models.Add(new VehicleModel() { Name = "ZX50" });
            man61.Models.Add(new VehicleModel() { Name = "אינובה 125" });
            man61.Models.Add(new VehicleModel() { Name = "באלי 50" });
            man61.Models.Add(new VehicleModel() { Name = "ג'אז 250" });
            man61.Models.Add(new VehicleModel() { Name = "ג'יירו X 50" });
            man61.Models.Add(new VehicleModel() { Name = "דילן 125" });
            man61.Models.Add(new VehicleModel() { Name = "דילן 150" });
            man61.Models.Add(new VehicleModel() { Name = "ויז'ן 110" });
            man61.Models.Add(new VehicleModel() { Name = "זומר" });
            man61.Models.Add(new VehicleModel() { Name = "ליד 100" });
            man61.Models.Add(new VehicleModel() { Name = "ניו ליד 110" });
            man61.Models.Add(new VehicleModel() { Name = "סופר דיו 50" });
            man61.Models.Add(new VehicleModel() { Name = "סופר קאב 50" });
            man61.Models.Add(new VehicleModel() { Name = "סילבר-ווינג 400" });
            man61.Models.Add(new VehicleModel() { Name = "סילבר-ווינג 600" });
            man61.Models.Add(new VehicleModel() { Name = "ספייסי 125" });
            man61.Models.Add(new VehicleModel() { Name = "סקיי 50" });
            man61.Models.Add(new VehicleModel() { Name = "פורזה 250" });
            man61.Models.Add(new VehicleModel() { Name = "פורזה NSS300" });
            man61.Models.Add(new VehicleModel() { Name = "פורסייט 250" });
            man61.Models.Add(new VehicleModel() { Name = "פנתאון 125" });
            man61.Models.Add(new VehicleModel() { Name = "פנתאון 150 2 פעימות" });
            man61.Models.Add(new VehicleModel() { Name = "פנתאון 150 4 פעימות" });
            man61.Models.Add(new VehicleModel() { Name = "אחר" });
            mans.Add(man61);
            VehicleManufacturer man62 = new VehicleManufacturer() { Type = 5, Name = "וקטריקס" };
            man62.Models = new List<VehicleModel>();
            man62.Models.Add(new VehicleModel() { Name = "אחר" });
            man62.Models.Add(new VehicleModel() { Name = "וקטריקס" });
            mans.Add(man62);
            VehicleManufacturer man63 = new VehicleManufacturer() { Type = 5, Name = "זונגשן" };
            man63.Models = new List<VehicleModel>();
            man63.Models.Add(new VehicleModel() { Name = "ZS125ST-7" });
            mans.Add(man63);
            VehicleManufacturer man64 = new VehicleManufacturer() { Type = 5, Name = "זנן" };
            man64.Models = new List<VehicleModel>();
            man64.Models.Add(new VehicleModel() { Name = "ZN125T-18" });
            man64.Models.Add(new VehicleModel() { Name = "ZN125T-19" });
            man64.Models.Add(new VehicleModel() { Name = "ZN125T-24" });
            man64.Models.Add(new VehicleModel() { Name = "ZN125T-E" });
            man64.Models.Add(new VehicleModel() { Name = "ZN125T-F" });
            man64.Models.Add(new VehicleModel() { Name = "אחר" });
            mans.Add(man64);
            VehicleManufacturer man65 = new VehicleManufacturer() { Type = 5, Name = "יוסאנג" };
            man65.Models = new List<VehicleModel>();
            man65.Models.Add(new VehicleModel() { Name = "MS3-125" });
            man65.Models.Add(new VehicleModel() { Name = "MS3-250" });
            man65.Models.Add(new VehicleModel() { Name = "MS3-250DLX" });
            man65.Models.Add(new VehicleModel() { Name = "SFB50B" });
            man65.Models.Add(new VehicleModel() { Name = "ביבר 125" });
            man65.Models.Add(new VehicleModel() { Name = "אחר" });
            mans.Add(man65);
            VehicleManufacturer man66 = new VehicleManufacturer() { Type = 5, Name = "ימאהה" };
            man66.Models = new List<VehicleModel>();
            man66.Models.Add(new VehicleModel() { Name = "BW\"s 50" });
            man66.Models.Add(new VehicleModel() { Name = "BW's 125" });
            man66.Models.Add(new VehicleModel() { Name = "DT50/SM" });
            man66.Models.Add(new VehicleModel() { Name = "Fly One 150" });
            man66.Models.Add(new VehicleModel() { Name = "Neo's 50" });
            man66.Models.Add(new VehicleModel() { Name = "Spy 50" });
            man66.Models.Add(new VehicleModel() { Name = "T-Max 500" });
            man66.Models.Add(new VehicleModel() { Name = "T-Max 500 Black" });
            man66.Models.Add(new VehicleModel() { Name = "T-Max 500 White" });
            man66.Models.Add(new VehicleModel() { Name = "X-City 125" });
            man66.Models.Add(new VehicleModel() { Name = "X-City 250" });
            man66.Models.Add(new VehicleModel() { Name = "X-Max 125" });
            man66.Models.Add(new VehicleModel() { Name = "X-Max 125 Black" });
            man66.Models.Add(new VehicleModel() { Name = "X-Max 125 Sport" });
            man66.Models.Add(new VehicleModel() { Name = "X-Max 250" });
            man66.Models.Add(new VehicleModel() { Name = "X-Max 250 Black" });
            man66.Models.Add(new VehicleModel() { Name = "X-Max 250 Sport" });
            man66.Models.Add(new VehicleModel() { Name = "X-Max 400" });
            man66.Models.Add(new VehicleModel() { Name = "XT350" });
            man66.Models.Add(new VehicleModel() { Name = "ארוקס 50" });
            man66.Models.Add(new VehicleModel() { Name = "באמפ 50" });
            man66.Models.Add(new VehicleModel() { Name = "ג'וג 50" });
            man66.Models.Add(new VehicleModel() { Name = "ורסיטי 300" });
            man66.Models.Add(new VehicleModel() { Name = "מג\"סטי 125" });
            man66.Models.Add(new VehicleModel() { Name = "מג\"סטי 400" });
            man66.Models.Add(new VehicleModel() { Name = "מג'סטי 250" });
            man66.Models.Add(new VehicleModel() { Name = "סיגנוס R 125" });
            man66.Models.Add(new VehicleModel() { Name = "סליידר 50" });
            man66.Models.Add(new VehicleModel() { Name = "אחר" });
            mans.Add(man66);
            VehicleManufacturer man67 = new VehicleManufacturer() { Type = 5, Name = "לונסין" };
            man67.Models = new List<VehicleModel>();
            man67.Models.Add(new VehicleModel() { Name = "LX125T-C" });
            man67.Models.Add(new VehicleModel() { Name = "TBL125A" });
            man67.Models.Add(new VehicleModel() { Name = "אחר" });
            mans.Add(man67);
            VehicleManufacturer man68 = new VehicleManufacturer() { Type = 5, Name = "ליפאן" };
            man68.Models = new List<VehicleModel>();
            man68.Models.Add(new VehicleModel() { Name = "LF150T-6" });
            man68.Models.Add(new VehicleModel() { Name = "LF250T-6B" });
            man68.Models.Add(new VehicleModel() { Name = "LFT-16 125" });
            man68.Models.Add(new VehicleModel() { Name = "LFT-6 125" });
            man68.Models.Add(new VehicleModel() { Name = "LFT-9A 125" });
            man68.Models.Add(new VehicleModel() { Name = "אחר" });
            mans.Add(man68);
            VehicleManufacturer man69 = new VehicleManufacturer() { Type = 5, Name = "למברטה" };
            man69.Models = new List<VehicleModel>();
            man69.Models.Add(new VehicleModel() { Name = "LN125" });
            mans.Add(man69);
            VehicleManufacturer man70 = new VehicleManufacturer() { Type = 5, Name = "מ.ב.ק" };
            man70.Models = new List<VehicleModel>();
            man70.Models.Add(new VehicleModel() { Name = "בוסטר" });
            man70.Models.Add(new VehicleModel() { Name = "אחר" });
            mans.Add(man70);
            VehicleManufacturer man71 = new VehicleManufacturer() { Type = 5, Name = "ניפוניה" };
            man71.Models = new List<VehicleModel>();
            man71.Models.Add(new VehicleModel() { Name = "Arte 125" });
            man71.Models.Add(new VehicleModel() { Name = "Arte 150" });
            man71.Models.Add(new VehicleModel() { Name = "Dion 125" });
            man71.Models.Add(new VehicleModel() { Name = "Ezio 125" });
            man71.Models.Add(new VehicleModel() { Name = "Vorrei 125" });
            man71.Models.Add(new VehicleModel() { Name = "Vorrei 150" });
            man71.Models.Add(new VehicleModel() { Name = "בריו 125" });
            mans.Add(man71);
            VehicleManufacturer man72 = new VehicleManufacturer() { Type = 5, Name = "סאן יאנג" };
            man72.Models = new List<VehicleModel>();
            man72.Models.Add(new VehicleModel() { Name = "HD125" });
            man72.Models.Add(new VehicleModel() { Name = "HD200" });
            man72.Models.Add(new VehicleModel() { Name = "SR50" });
            man72.Models.Add(new VehicleModel() { Name = "VS125" });
            man72.Models.Add(new VehicleModel() { Name = "אורביט 125" });
            man72.Models.Add(new VehicleModel() { Name = "אטילה 150" });
            man72.Models.Add(new VehicleModel() { Name = "ג'וי-מקס 300 xi" });
            man72.Models.Add(new VehicleModel() { Name = "ג\"וי רייד 125" });
            man72.Models.Add(new VehicleModel() { Name = "ג\"וי רייד 150" });
            man72.Models.Add(new VehicleModel() { Name = "ג\"וי רייד 200" });
            man72.Models.Add(new VehicleModel() { Name = "ג\"וי-מקס 125" });
            man72.Models.Add(new VehicleModel() { Name = "ג\"וי-מקס 250" });
            man72.Models.Add(new VehicleModel() { Name = "ג'ונגל 50" });
            man72.Models.Add(new VehicleModel() { Name = "ג'ט 125" });
            man72.Models.Add(new VehicleModel() { Name = "ג'ט 50" });
            man72.Models.Add(new VehicleModel() { Name = "דיו/פיור SP50" });
            man72.Models.Add(new VehicleModel() { Name = "דיוק 125 קלאסיק" });
            man72.Models.Add(new VehicleModel() { Name = "דיוק 150" });
            man72.Models.Add(new VehicleModel() { Name = "יורו MX 150" });
            man72.Models.Add(new VehicleModel() { Name = "מאסק 50" });
            man72.Models.Add(new VehicleModel() { Name = "מיו 100" });
            man72.Models.Add(new VehicleModel() { Name = "מיו 50" });
            man72.Models.Add(new VehicleModel() { Name = "מקסים 400i" });
            man72.Models.Add(new VehicleModel() { Name = "ניו דיוק 125" });
            man72.Models.Add(new VehicleModel() { Name = "ניו-ג\"ט 50" });
            man72.Models.Add(new VehicleModel() { Name = "סופר דיוק 125" });
            man72.Models.Add(new VehicleModel() { Name = "סופר דיוק 150" });
            man72.Models.Add(new VehicleModel() { Name = "סופר פיור 50" });
            man72.Models.Add(new VehicleModel() { Name = "סופר פנסי 50" });
            man72.Models.Add(new VehicleModel() { Name = "סיטיקום 300i" });
            man72.Models.Add(new VehicleModel() { Name = "פידל 125" });
            man72.Models.Add(new VehicleModel() { Name = "פיל ביג 50/90" });
            man72.Models.Add(new VehicleModel() { Name = "פנסי / R" });
            man72.Models.Add(new VehicleModel() { Name = "שארק 125" });
            man72.Models.Add(new VehicleModel() { Name = "אחר" });
            mans.Add(man72);
            VehicleManufacturer man73 = new VehicleManufacturer() { Type = 5, Name = "סוזוקי" };
            man73.Models = new List<VehicleModel>();
            man73.Models.Add(new VehicleModel() { Name = "AD50" });
            man73.Models.Add(new VehicleModel() { Name = "בורגמן 125" });
            man73.Models.Add(new VehicleModel() { Name = "בורגמן 200" });
            man73.Models.Add(new VehicleModel() { Name = "בורגמן 250" });
            man73.Models.Add(new VehicleModel() { Name = "בורגמן 400" });
            man73.Models.Add(new VehicleModel() { Name = "בורגמן 400 A" });
            man73.Models.Add(new VehicleModel() { Name = "בורגמן 400 AZ" });
            man73.Models.Add(new VehicleModel() { Name = "בורגמן 400 Z" });
            man73.Models.Add(new VehicleModel() { Name = "בורגמן 650" });
            man73.Models.Add(new VehicleModel() { Name = "בורגמן 650 Executive/AZ" });
            man73.Models.Add(new VehicleModel() { Name = "פרונטיר 100" });
            man73.Models.Add(new VehicleModel() { Name = "אחר" });
            mans.Add(man73);
            VehicleManufacturer man74 = new VehicleManufacturer() { Type = 5, Name = "פיאג'ו" };
            man74.Models = new List<VehicleModel>();
            man74.Models.Add(new VehicleModel() { Name = "FLY 125" });
            man74.Models.Add(new VehicleModel() { Name = "Fuoco 500" });
            man74.Models.Add(new VehicleModel() { Name = "MP3 125" });
            man74.Models.Add(new VehicleModel() { Name = "MP3 125 Yourban" });
            man74.Models.Add(new VehicleModel() { Name = "MP3 250" });
            man74.Models.Add(new VehicleModel() { Name = "MP3 300 Yourban" });
            man74.Models.Add(new VehicleModel() { Name = "MP3 400" });
            man74.Models.Add(new VehicleModel() { Name = "NRG 50" });
            man74.Models.Add(new VehicleModel() { Name = "NTT 50" });
            man74.Models.Add(new VehicleModel() { Name = "SKR 150" });
            man74.Models.Add(new VehicleModel() { Name = "X-Evo 125" });
            man74.Models.Add(new VehicleModel() { Name = "X-Evo 250" });
            man74.Models.Add(new VehicleModel() { Name = "X-Evo 400" });
            man74.Models.Add(new VehicleModel() { Name = "X7 250" });
            man74.Models.Add(new VehicleModel() { Name = "X8 125" });
            man74.Models.Add(new VehicleModel() { Name = "X8 250" });
            man74.Models.Add(new VehicleModel() { Name = "X9 500" });
            man74.Models.Add(new VehicleModel() { Name = "בוורלי 125" });
            man74.Models.Add(new VehicleModel() { Name = "בוורלי 300" });
            man74.Models.Add(new VehicleModel() { Name = "בוורלי 500" });
            man74.Models.Add(new VehicleModel() { Name = "הקסגון 150" });
            man74.Models.Add(new VehicleModel() { Name = "הקסגון GT/GTX 250" });
            man74.Models.Add(new VehicleModel() { Name = "וספה 150" });
            man74.Models.Add(new VehicleModel() { Name = "וספה ET2" });
            man74.Models.Add(new VehicleModel() { Name = "וספה ET4 125" });
            man74.Models.Add(new VehicleModel() { Name = "וספה GTS250" });
            man74.Models.Add(new VehicleModel() { Name = "וספה GTS300 סופר" });
            man74.Models.Add(new VehicleModel() { Name = "וספה LX125" });
            man74.Models.Add(new VehicleModel() { Name = "וספה LX50" });
            man74.Models.Add(new VehicleModel() { Name = "וספה PX200E" });
            man74.Models.Add(new VehicleModel() { Name = "זיפ 50" });
            man74.Models.Add(new VehicleModel() { Name = "טייפון 125" });
            man74.Models.Add(new VehicleModel() { Name = "טייפון X 50" });
            man74.Models.Add(new VehicleModel() { Name = "סי 50" });
            man74.Models.Add(new VehicleModel() { Name = "ספרה 50" });
            man74.Models.Add(new VehicleModel() { Name = "סקיפר 150" });
            man74.Models.Add(new VehicleModel() { Name = "פרי 50" });
            man74.Models.Add(new VehicleModel() { Name = "קווארץ 50" });
            man74.Models.Add(new VehicleModel() { Name = "אחר" });
            mans.Add(man74);
            VehicleManufacturer man75 = new VehicleManufacturer() { Type = 5, Name = "פיג'ו" };
            man75.Models = new List<VehicleModel>();
            man75.Models.Add(new VehicleModel() { Name = "Geopolis 125" });
            man75.Models.Add(new VehicleModel() { Name = "Geopolis 300 RS" });
            man75.Models.Add(new VehicleModel() { Name = "Geopolis 400 RS" });
            man75.Models.Add(new VehicleModel() { Name = "Satelis 125" });
            man75.Models.Add(new VehicleModel() { Name = "Satelis 400 RS" });
            man75.Models.Add(new VehicleModel() { Name = "Satelis 500 RS" });
            man75.Models.Add(new VehicleModel() { Name = "Sum-Up 125" });
            man75.Models.Add(new VehicleModel() { Name = "Tweet 125" });
            man75.Models.Add(new VehicleModel() { Name = "Viva City 125" });
            man75.Models.Add(new VehicleModel() { Name = "אליזאו 125" });
            man75.Models.Add(new VehicleModel() { Name = "באקסי 50" });
            man75.Models.Add(new VehicleModel() { Name = "ג\"ט פורס 125" });
            man75.Models.Add(new VehicleModel() { Name = "ג\"ט פורס 50" });
            man75.Models.Add(new VehicleModel() { Name = "ויוה סיטי 50" });
            man75.Models.Add(new VehicleModel() { Name = "ויוה סיטי בלו-ליין 50" });
            man75.Models.Add(new VehicleModel() { Name = "טרקר Off Road 50" });
            man75.Models.Add(new VehicleModel() { Name = "טרקר Road 50" });
            man75.Models.Add(new VehicleModel() { Name = "לודיקס 50" });
            man75.Models.Add(new VehicleModel() { Name = "סטריט-בורד 50" });
            man75.Models.Add(new VehicleModel() { Name = "ספידפייט/2 50" });
            man75.Models.Add(new VehicleModel() { Name = "ספידק 50" });
            man75.Models.Add(new VehicleModel() { Name = "סקוואב 50" });
            man75.Models.Add(new VehicleModel() { Name = "פוקס 50" });
            man75.Models.Add(new VehicleModel() { Name = "אחר" });
            mans.Add(man75);
            VehicleManufacturer man76 = new VehicleManufacturer() { Type = 5, Name = "קאג'יבה" };
            man76.Models = new List<VehicleModel>();
            man76.Models.Add(new VehicleModel() { Name = "AZ" });
            man76.Models.Add(new VehicleModel() { Name = "RX/פריציה" });
            man76.Models.Add(new VehicleModel() { Name = "T4" });
            man76.Models.Add(new VehicleModel() { Name = "W-4" });
            man76.Models.Add(new VehicleModel() { Name = "אלה רוסה" });
            man76.Models.Add(new VehicleModel() { Name = "אלפנט" });
            man76.Models.Add(new VehicleModel() { Name = "מיטו" });
            man76.Models.Add(new VehicleModel() { Name = "סופר סיטי" });
            man76.Models.Add(new VehicleModel() { Name = "פרימה" });
            man76.Models.Add(new VehicleModel() { Name = "אחר" });
            mans.Add(man76);
            VehicleManufacturer man77 = new VehicleManufacturer() { Type = 5, Name = "קוואנג-יאנג" };
            man77.Models = new List<VehicleModel>();
            man77.Models.Add(new VehicleModel() { Name = "דינק 50" });
            man77.Models.Add(new VehicleModel() { Name = "אחר" });
            mans.Add(man77);
            VehicleManufacturer man78 = new VehicleManufacturer() { Type = 5, Name = "קיוואי" };
            man78.Models = new List<VehicleModel>();
            man78.Models.Add(new VehicleModel() { Name = "ARN125" });
            man78.Models.Add(new VehicleModel() { Name = "ARN125 רייסינג" });
            man78.Models.Add(new VehicleModel() { Name = "F-ACT125" });
            man78.Models.Add(new VehicleModel() { Name = "אאוטלוק 125" });
            man78.Models.Add(new VehicleModel() { Name = "אאוטלוק ספורט 125" });
            man78.Models.Add(new VehicleModel() { Name = "אחר" });
            man78.Models.Add(new VehicleModel() { Name = "האקר 125" });
            man78.Models.Add(new VehicleModel() { Name = "הוריקן 50" });
            man78.Models.Add(new VehicleModel() { Name = "מטריקס 125" });
            mans.Add(man78);
            VehicleManufacturer man79 = new VehicleManufacturer() { Type = 5, Name = "קימקו" };
            man79.Models = new List<VehicleModel>();
            man79.Models.Add(new VehicleModel() { Name = "B&W 150" });
            man79.Models.Add(new VehicleModel() { Name = "B&W 250" });
            man79.Models.Add(new VehicleModel() { Name = "CX50" });
            man79.Models.Add(new VehicleModel() { Name = "DJX/R50" });
            man79.Models.Add(new VehicleModel() { Name = "KB50" });
            man79.Models.Add(new VehicleModel() { Name = "ZX50" });
            man79.Models.Add(new VehicleModel() { Name = "אג'יליטי 125" });
            man79.Models.Add(new VehicleModel() { Name = "אג'יליטי סיטי 125" });
            man79.Models.Add(new VehicleModel() { Name = "אקסייטינג 250" });
            man79.Models.Add(new VehicleModel() { Name = "אקסייטינג 250Ri" });
            man79.Models.Add(new VehicleModel() { Name = "אקסייטינג 300R" });
            man79.Models.Add(new VehicleModel() { Name = "אקסייטינג 500" });
            man79.Models.Add(new VehicleModel() { Name = "גראנד דינק 150" });
            man79.Models.Add(new VehicleModel() { Name = "גראנד דינק 250" });
            man79.Models.Add(new VehicleModel() { Name = "גרנד דינק 125" });
            man79.Models.Add(new VehicleModel() { Name = "דאון-טאון 125" });
            man79.Models.Add(new VehicleModel() { Name = "דאון-טאון 200" });
            man79.Models.Add(new VehicleModel() { Name = "דאון-טאון 300" });
            man79.Models.Add(new VehicleModel() { Name = "דינק 150" });
            man79.Models.Add(new VehicleModel() { Name = "דינק 200" });
            man79.Models.Add(new VehicleModel() { Name = "דינק 50" });
            man79.Models.Add(new VehicleModel() { Name = "הרואיזם 125" });
            man79.Models.Add(new VehicleModel() { Name = "הרואיזם 150" });
            man79.Models.Add(new VehicleModel() { Name = "הרואיזם 50" });
            man79.Models.Add(new VehicleModel() { Name = "ויויו 125" });
            man79.Models.Add(new VehicleModel() { Name = "ויטאליטי 50" });
            man79.Models.Add(new VehicleModel() { Name = "טופ בוי 50" });
            man79.Models.Add(new VehicleModel() { Name = "מובי 125XL" });
            man79.Models.Add(new VehicleModel() { Name = "מובי 150" });
            man79.Models.Add(new VehicleModel() { Name = "ניו-דינק 125E" });
            man79.Models.Add(new VehicleModel() { Name = "ניו-דינק 200I" });
            man79.Models.Add(new VehicleModel() { Name = "סופר ג\"וקי 125" });
            man79.Models.Add(new VehicleModel() { Name = "סנטו 100" });
            man79.Models.Add(new VehicleModel() { Name = "פיפל 125S" });
            man79.Models.Add(new VehicleModel() { Name = "פריוואי/ג\"וקי 125/150" });
            man79.Models.Add(new VehicleModel() { Name = "אחר" });
            mans.Add(man79);
            VehicleManufacturer man80 = new VehicleManufacturer() { Type = 5, Name = "קליבלנד" };
            man80.Models = new List<VehicleModel>();
            man80.Models.Add(new VehicleModel() { Name = "tha heist 125" });
            man80.Models.Add(new VehicleModel() { Name = "tha heist 250" });
            mans.Add(man80);
            VehicleManufacturer man81 = new VehicleManufacturer() { Type = 5, Name = "קסינג-יו" };
            man81.Models = new List<VehicleModel>();
            man81.Models.Add(new VehicleModel() { Name = "XY125T-11" });
            man81.Models.Add(new VehicleModel() { Name = "XY125T-13" });
            man81.Models.Add(new VehicleModel() { Name = "XY125ZK (סייף סיטי) 125" });
            man81.Models.Add(new VehicleModel() { Name = "XY125ZK (סייף סיטי) 125" });
            man81.Models.Add(new VehicleModel() { Name = "XY150T" });
            man81.Models.Add(new VehicleModel() { Name = "אחר" });
            mans.Add(man81);
            VehicleManufacturer man82 = new VehicleManufacturer() { Type = 5, Name = "אחר" };
            man82.Models = new List<VehicleModel>();
            man82.Models.Add(new VehicleModel() { Name = "כללי" });
            mans.Add(man82);
            VehicleManufacturer man83 = new VehicleManufacturer() { Type = 5, Name = "מחפש!" };
            man83.Models = new List<VehicleModel>();
            man83.Models.Add(new VehicleModel() { Name = "מחפש קטנוע" });
            mans.Add(man83);
            VehicleManufacturer man84 = new VehicleManufacturer() { Type = 1, Name = "אאודי" };
            man84.Models = new List<VehicleModel>();
            man84.Models.Add(new VehicleModel() { Name = "100" });
            man84.Models.Add(new VehicleModel() { Name = "80" });
            man84.Models.Add(new VehicleModel() { Name = "A1" });
            man84.Models.Add(new VehicleModel() { Name = "A3" });
            man84.Models.Add(new VehicleModel() { Name = "A4" });
            man84.Models.Add(new VehicleModel() { Name = "A5" });
            man84.Models.Add(new VehicleModel() { Name = "A6" });
            man84.Models.Add(new VehicleModel() { Name = "A7" });
            man84.Models.Add(new VehicleModel() { Name = "A8" });
            man84.Models.Add(new VehicleModel() { Name = "R8" });
            man84.Models.Add(new VehicleModel() { Name = "S3" });
            man84.Models.Add(new VehicleModel() { Name = "S4" });
            man84.Models.Add(new VehicleModel() { Name = "S5" });
            man84.Models.Add(new VehicleModel() { Name = "S6" });
            man84.Models.Add(new VehicleModel() { Name = "S8" });
            man84.Models.Add(new VehicleModel() { Name = "TT" });
            man84.Models.Add(new VehicleModel() { Name = "אולרוד" });
            mans.Add(man84);
            VehicleManufacturer man85 = new VehicleManufacturer() { Type = 1, Name = "אברת'" };
            man85.Models = new List<VehicleModel>();
            man85.Models.Add(new VehicleModel() { Name = "Abarth 500" });
            man85.Models.Add(new VehicleModel() { Name = "Abarth 500c" });
            man85.Models.Add(new VehicleModel() { Name = "Abarth פונטו איבו" });
            mans.Add(man85);
            VehicleManufacturer man86 = new VehicleManufacturer() { Type = 1, Name = "אוטוביאנקי" };
            man86.Models = new List<VehicleModel>();
            man86.Models.Add(new VehicleModel() { Name = "Y10" });
            man86.Models.Add(new VehicleModel() { Name = "ג'וניור" });
            mans.Add(man86);
            VehicleManufacturer man87 = new VehicleManufacturer() { Type = 1, Name = "אולדסמוביל" };
            man87.Models = new List<VehicleModel>();
            man87.Models.Add(new VehicleModel() { Name = "אומגה" });
            man87.Models.Add(new VehicleModel() { Name = "דלתא" });
            man87.Models.Add(new VehicleModel() { Name = "קטלס" });
            mans.Add(man87);
            VehicleManufacturer man88 = new VehicleManufacturer() { Type = 1, Name = "אוסטין" };
            man88.Models = new List<VehicleModel>();
            man88.Models.Add(new VehicleModel() { Name = "מאסטרו" });
            man88.Models.Add(new VehicleModel() { Name = "מונטגו" });
            man88.Models.Add(new VehicleModel() { Name = "מטרו" });
            man88.Models.Add(new VehicleModel() { Name = "מיני" });
            mans.Add(man88);
            VehicleManufacturer man89 = new VehicleManufacturer() { Type = 1, Name = "אופל" };
            man89.Models = new List<VehicleModel>();
            man89.Models.Add(new VehicleModel() { Name = "אומגה" });
            man89.Models.Add(new VehicleModel() { Name = "אינסיגניה" });
            man89.Models.Add(new VehicleModel() { Name = "אסטרה" });
            man89.Models.Add(new VehicleModel() { Name = "אסקונה" });
            man89.Models.Add(new VehicleModel() { Name = "וקטרה" });
            man89.Models.Add(new VehicleModel() { Name = "זאפירה" });
            man89.Models.Add(new VehicleModel() { Name = "טיגרה" });
            man89.Models.Add(new VehicleModel() { Name = "מריבה" });
            man89.Models.Add(new VehicleModel() { Name = "קדט" });
            man89.Models.Add(new VehicleModel() { Name = "קורסה" });
            man89.Models.Add(new VehicleModel() { Name = "קסקדה" });
            mans.Add(man89);
            VehicleManufacturer man90 = new VehicleManufacturer() { Type = 1, Name = "אינפיניטי" };
            man90.Models = new List<VehicleModel>();
            man90.Models.Add(new VehicleModel() { Name = "G37" });
            man90.Models.Add(new VehicleModel() { Name = "G37" });
            man90.Models.Add(new VehicleModel() { Name = "G37" });
            man90.Models.Add(new VehicleModel() { Name = "M37" });
            mans.Add(man90);
            VehicleManufacturer man91 = new VehicleManufacturer() { Type = 1, Name = "אלפא-רומאו" };
            man91.Models = new List<VehicleModel>();
            man91.Models.Add(new VehicleModel() { Name = "145" });
            man91.Models.Add(new VehicleModel() { Name = "146" });
            man91.Models.Add(new VehicleModel() { Name = "147" });
            man91.Models.Add(new VehicleModel() { Name = "156" });
            man91.Models.Add(new VehicleModel() { Name = "159" });
            man91.Models.Add(new VehicleModel() { Name = "164" });
            man91.Models.Add(new VehicleModel() { Name = "166" });
            man91.Models.Add(new VehicleModel() { Name = "33" });
            man91.Models.Add(new VehicleModel() { Name = "4C" });
            man91.Models.Add(new VehicleModel() { Name = "75" });
            man91.Models.Add(new VehicleModel() { Name = "90" });
            man91.Models.Add(new VehicleModel() { Name = "GT" });
            man91.Models.Add(new VehicleModel() { Name = "GTV" });
            man91.Models.Add(new VehicleModel() { Name = "בררה" });
            man91.Models.Add(new VehicleModel() { Name = "ג'ולייטה" });
            man91.Models.Add(new VehicleModel() { Name = "מיטו / MITO" });
            man91.Models.Add(new VehicleModel() { Name = "סוד" });
            man91.Models.Add(new VehicleModel() { Name = "ספיידר" });
            man91.Models.Add(new VehicleModel() { Name = "ספרינט" });
            mans.Add(man91);
            VehicleManufacturer man92 = new VehicleManufacturer() { Type = 1, Name = "אם. ג'י. / MG" };
            man92.Models = new List<VehicleModel>();
            man92.Models.Add(new VehicleModel() { Name = "350" });
            man92.Models.Add(new VehicleModel() { Name = "550" });
            mans.Add(man92);
            VehicleManufacturer man93 = new VehicleManufacturer() { Type = 1, Name = "ב מ וו" };
            man93.Models = new List<VehicleModel>();
            man93.Models.Add(new VehicleModel() { Name = "M1" });
            man93.Models.Add(new VehicleModel() { Name = "M3" });
            man93.Models.Add(new VehicleModel() { Name = "M5" });
            man93.Models.Add(new VehicleModel() { Name = "M6" });
            man93.Models.Add(new VehicleModel() { Name = "Z3" });
            man93.Models.Add(new VehicleModel() { Name = "Z4" });
            man93.Models.Add(new VehicleModel() { Name = "סדרה 1" });
            man93.Models.Add(new VehicleModel() { Name = "סדרה 3" });
            man93.Models.Add(new VehicleModel() { Name = "סדרה 3 קופה / קבריולט" });
            man93.Models.Add(new VehicleModel() { Name = "סדרה 4" });
            man93.Models.Add(new VehicleModel() { Name = "סדרה 5" });
            man93.Models.Add(new VehicleModel() { Name = "סדרה 6" });
            man93.Models.Add(new VehicleModel() { Name = "סדרה 7" });
            man93.Models.Add(new VehicleModel() { Name = "סדרה 8" });
            mans.Add(man93);
            VehicleManufacturer man94 = new VehicleManufacturer() { Type = 1, Name = "ביואיק" };
            man94.Models = new List<VehicleModel>();
            man94.Models.Add(new VehicleModel() { Name = "לה סייבר" });
            man94.Models.Add(new VehicleModel() { Name = "לה קרוס" });
            man94.Models.Add(new VehicleModel() { Name = "לוצרן" });
            man94.Models.Add(new VehicleModel() { Name = "סנצ'ורי" });
            man94.Models.Add(new VehicleModel() { Name = "פארק אבניו" });
            man94.Models.Add(new VehicleModel() { Name = "ריביירה" });
            man94.Models.Add(new VehicleModel() { Name = "ריגל" });
            mans.Add(man94);
            VehicleManufacturer man95 = new VehicleManufacturer() { Type = 1, Name = "ג'יאו - Geo" };
            man95.Models = new List<VehicleModel>();
            man95.Models.Add(new VehicleModel() { Name = "פריזם" });
            mans.Add(man95);
            VehicleManufacturer man96 = new VehicleManufacturer() { Type = 1, Name = "גרייט וול" };
            man96.Models = new List<VehicleModel>();
            man96.Models.Add(new VehicleModel() { Name = "C10" });
            mans.Add(man96);
            VehicleManufacturer man97 = new VehicleManufacturer() { Type = 1, Name = "דודג'" };
            man97.Models = new List<VehicleModel>();
            man97.Models.Add(new VehicleModel() { Name = "אוונג'ר" });
            man97.Models.Add(new VehicleModel() { Name = "אספן" });
            man97.Models.Add(new VehicleModel() { Name = "אריס" });
            man97.Models.Add(new VehicleModel() { Name = "ג'רני" });
            man97.Models.Add(new VehicleModel() { Name = "דארט" });
            man97.Models.Add(new VehicleModel() { Name = "וייפר" });
            man97.Models.Add(new VehicleModel() { Name = "ולי" });
            man97.Models.Add(new VehicleModel() { Name = "פלימות'" });
            man97.Models.Add(new VehicleModel() { Name = "צ'ארג'ר" });
            man97.Models.Add(new VehicleModel() { Name = "קאליבר" });
            mans.Add(man97);
            VehicleManufacturer man98 = new VehicleManufacturer() { Type = 1, Name = "דייהו" };
            man98.Models = new List<VehicleModel>();
            man98.Models.Add(new VehicleModel() { Name = "אספרו" });
            man98.Models.Add(new VehicleModel() { Name = "לאנוס" });
            man98.Models.Add(new VehicleModel() { Name = "לגנזה" });
            man98.Models.Add(new VehicleModel() { Name = "מאטיס" });
            man98.Models.Add(new VehicleModel() { Name = "נובירה" });
            man98.Models.Add(new VehicleModel() { Name = "נקסייה" });
            man98.Models.Add(new VehicleModel() { Name = "סופר סלון" });
            man98.Models.Add(new VehicleModel() { Name = "סופר רייסר" });
            man98.Models.Add(new VehicleModel() { Name = "פרינס" });
            man98.Models.Add(new VehicleModel() { Name = "רייסר" });
            mans.Add(man98);
            VehicleManufacturer man99 = new VehicleManufacturer() { Type = 1, Name = "דייהטסו" };
            man99.Models = new List<VehicleModel>();
            man99.Models.Add(new VehicleModel() { Name = "YRV" });
            man99.Models.Add(new VehicleModel() { Name = "אפלאוז" });
            man99.Models.Add(new VehicleModel() { Name = "גרנדמוב" });
            man99.Models.Add(new VehicleModel() { Name = "מאטריה" });
            man99.Models.Add(new VehicleModel() { Name = "סיריון" });
            man99.Models.Add(new VehicleModel() { Name = "קורה" });
            man99.Models.Add(new VehicleModel() { Name = "שרייד" });
            man99.Models.Add(new VehicleModel() { Name = "שרמנט" });
            mans.Add(man99);
            VehicleManufacturer man100 = new VehicleManufacturer() { Type = 1, Name = "הונדה" };
            man100.Models = new List<VehicleModel>();
            man100.Models.Add(new VehicleModel() { Name = "CR-Z" });
            man100.Models.Add(new VehicleModel() { Name = "FR-V" });
            man100.Models.Add(new VehicleModel() { Name = "S 2000" });
            man100.Models.Add(new VehicleModel() { Name = "TYPE R" });
            man100.Models.Add(new VehicleModel() { Name = "אודסיי" });
            man100.Models.Add(new VehicleModel() { Name = "אינסייט" });
            man100.Models.Add(new VehicleModel() { Name = "אקורד" });
            man100.Models.Add(new VehicleModel() { Name = "ג'אז" });
            man100.Models.Add(new VehicleModel() { Name = "לג'נד" });
            man100.Models.Add(new VehicleModel() { Name = "סטרים" });
            man100.Models.Add(new VehicleModel() { Name = "סיוויק האצ'בק החדשה" });
            man100.Models.Add(new VehicleModel() { Name = "סיוויק סדאן החדשה" });
            man100.Models.Add(new VehicleModel() { Name = "סיויק (עד 2006)" });
            man100.Models.Add(new VehicleModel() { Name = "סיויק היבריד" });
            man100.Models.Add(new VehicleModel() { Name = "סיויק קופה / הצ'בק" });
            man100.Models.Add(new VehicleModel() { Name = "פרלוד" });
            man100.Models.Add(new VehicleModel() { Name = "שאטל" });
            mans.Add(man100);
            VehicleManufacturer man101 = new VehicleManufacturer() { Type = 1, Name = "וולוו" };
            man101.Models = new List<VehicleModel>();
            man101.Models.Add(new VehicleModel() { Name = "240" });
            man101.Models.Add(new VehicleModel() { Name = "244" });
            man101.Models.Add(new VehicleModel() { Name = "245" });
            man101.Models.Add(new VehicleModel() { Name = "264" });
            man101.Models.Add(new VehicleModel() { Name = "340/345" });
            man101.Models.Add(new VehicleModel() { Name = "740/744" });
            man101.Models.Add(new VehicleModel() { Name = "745" });
            man101.Models.Add(new VehicleModel() { Name = "760" });
            man101.Models.Add(new VehicleModel() { Name = "850" });
            man101.Models.Add(new VehicleModel() { Name = "854" });
            man101.Models.Add(new VehicleModel() { Name = "855" });
            man101.Models.Add(new VehicleModel() { Name = "940" });
            man101.Models.Add(new VehicleModel() { Name = "944" });
            man101.Models.Add(new VehicleModel() { Name = "945" });
            man101.Models.Add(new VehicleModel() { Name = "960" });
            man101.Models.Add(new VehicleModel() { Name = "C30" });
            man101.Models.Add(new VehicleModel() { Name = "C70" });
            man101.Models.Add(new VehicleModel() { Name = "S40" });
            man101.Models.Add(new VehicleModel() { Name = "S60" });
            man101.Models.Add(new VehicleModel() { Name = "S70" });
            man101.Models.Add(new VehicleModel() { Name = "S80" });
            man101.Models.Add(new VehicleModel() { Name = "S90" });
            man101.Models.Add(new VehicleModel() { Name = "V40" });
            man101.Models.Add(new VehicleModel() { Name = "V40 CC" });
            man101.Models.Add(new VehicleModel() { Name = "V40 הישנה" });
            man101.Models.Add(new VehicleModel() { Name = "V50" });
            man101.Models.Add(new VehicleModel() { Name = "V60" });
            man101.Models.Add(new VehicleModel() { Name = "V70" });
            man101.Models.Add(new VehicleModel() { Name = "XC70" });
            mans.Add(man101);
            VehicleManufacturer man102 = new VehicleManufacturer() { Type = 1, Name = "טויוטה" };
            man102.Models = new List<VehicleModel>();
            man102.Models.Add(new VehicleModel() { Name = "GT86" });
            man102.Models.Add(new VehicleModel() { Name = "MR2" });
            man102.Models.Add(new VehicleModel() { Name = "אוולון" });
            man102.Models.Add(new VehicleModel() { Name = "אוונסיס" });
            man102.Models.Add(new VehicleModel() { Name = "אוריס" });
            man102.Models.Add(new VehicleModel() { Name = "אייגו (AYGO)" });
            man102.Models.Add(new VehicleModel() { Name = "ורסו" });
            man102.Models.Add(new VehicleModel() { Name = "יאריס" });
            man102.Models.Add(new VehicleModel() { Name = "יאריס הייבריד" });
            man102.Models.Add(new VehicleModel() { Name = "סולרה קבריולט" });
            man102.Models.Add(new VehicleModel() { Name = "סטארלט" });
            man102.Models.Add(new VehicleModel() { Name = "סיינה" });
            man102.Models.Add(new VehicleModel() { Name = "סליקה" });
            man102.Models.Add(new VehicleModel() { Name = "ספייס ורסו" });
            man102.Models.Add(new VehicleModel() { Name = "פריוויה" });
            man102.Models.Add(new VehicleModel() { Name = "פריוס" });
            man102.Models.Add(new VehicleModel() { Name = "פריוס פלוס" });
            man102.Models.Add(new VehicleModel() { Name = "קאמרי" });
            man102.Models.Add(new VehicleModel() { Name = "קורולה" });
            man102.Models.Add(new VehicleModel() { Name = "קורולה RUN-X" });
            man102.Models.Add(new VehicleModel() { Name = "קרינה" });
            mans.Add(man102);
            VehicleManufacturer man103 = new VehicleManufacturer() { Type = 1, Name = "יגואר" };
            man103.Models = new List<VehicleModel>();
            man103.Models.Add(new VehicleModel() { Name = "F-Type" });
            man103.Models.Add(new VehicleModel() { Name = "S-TYPE" });
            man103.Models.Add(new VehicleModel() { Name = "X-TYPE" });
            man103.Models.Add(new VehicleModel() { Name = "XF" });
            man103.Models.Add(new VehicleModel() { Name = "XJ" });
            man103.Models.Add(new VehicleModel() { Name = "XJ6" });
            man103.Models.Add(new VehicleModel() { Name = "XJ8" });
            man103.Models.Add(new VehicleModel() { Name = "XJR" });
            man103.Models.Add(new VehicleModel() { Name = "XK" });
            man103.Models.Add(new VehicleModel() { Name = "XK8" });
            man103.Models.Add(new VehicleModel() { Name = "XKR" });
            man103.Models.Add(new VehicleModel() { Name = "דימלר" });
            man103.Models.Add(new VehicleModel() { Name = "סוברין" });
            mans.Add(man103);
            VehicleManufacturer man104 = new VehicleManufacturer() { Type = 1, Name = "יונדאי" };
            man104.Models = new List<VehicleModel>();
            man104.Models.Add(new VehicleModel() { Name = "i10" });
            man104.Models.Add(new VehicleModel() { Name = "i20" });
            man104.Models.Add(new VehicleModel() { Name = "i25" });
            man104.Models.Add(new VehicleModel() { Name = "i30" });
            man104.Models.Add(new VehicleModel() { Name = "i30CW" });
            man104.Models.Add(new VehicleModel() { Name = "i35" });
            man104.Models.Add(new VehicleModel() { Name = "i40" });
            man104.Models.Add(new VehicleModel() { Name = "iX20" });
            man104.Models.Add(new VehicleModel() { Name = "אטוס" });
            man104.Models.Add(new VehicleModel() { Name = "אלנטרה" });
            man104.Models.Add(new VehicleModel() { Name = "אקסנט" });
            man104.Models.Add(new VehicleModel() { Name = "גטס" });
            man104.Models.Add(new VehicleModel() { Name = "ולוסטר" });
            man104.Models.Add(new VehicleModel() { Name = "טרג'ט" });
            man104.Models.Add(new VehicleModel() { Name = "לנטרה" });
            man104.Models.Add(new VehicleModel() { Name = "מטריקס" });
            man104.Models.Add(new VehicleModel() { Name = "סונטה" });
            man104.Models.Add(new VehicleModel() { Name = "קופה" });
            mans.Add(man104);
            VehicleManufacturer man105 = new VehicleManufacturer() { Type = 1, Name = "לאדה" };
            man105.Models = new List<VehicleModel>();
            man105.Models.Add(new VehicleModel() { Name = "סמרה" });
            mans.Add(man105);
            VehicleManufacturer man106 = new VehicleManufacturer() { Type = 1, Name = "לינקולן" };
            man106.Models = new List<VehicleModel>();
            man106.Models.Add(new VehicleModel() { Name = "LS" });
            man106.Models.Add(new VehicleModel() { Name = "MKS" });
            man106.Models.Add(new VehicleModel() { Name = "MKZ" });
            man106.Models.Add(new VehicleModel() { Name = "זפיר" });
            man106.Models.Add(new VehicleModel() { Name = "טאון קאר" });
            mans.Add(man106);
            VehicleManufacturer man107 = new VehicleManufacturer() { Type = 1, Name = "לנציה" };
            man107.Models = new List<VehicleModel>();
            man107.Models.Add(new VehicleModel() { Name = "אפסילון" });
            man107.Models.Add(new VehicleModel() { Name = "בטה" });
            man107.Models.Add(new VehicleModel() { Name = "דדרה" });
            man107.Models.Add(new VehicleModel() { Name = "דלתא" });
            man107.Models.Add(new VehicleModel() { Name = "פריזמה" });
            man107.Models.Add(new VehicleModel() { Name = "קאפה" });
            man107.Models.Add(new VehicleModel() { Name = "תמה" });
            mans.Add(man107);
            VehicleManufacturer man108 = new VehicleManufacturer() { Type = 1, Name = "לקסוס" };
            man108.Models = new List<VehicleModel>();
            man108.Models.Add(new VehicleModel() { Name = "CS" });
            man108.Models.Add(new VehicleModel() { Name = "CT200H" });
            man108.Models.Add(new VehicleModel() { Name = "GS250" });
            man108.Models.Add(new VehicleModel() { Name = "GS300" });
            man108.Models.Add(new VehicleModel() { Name = "GS300H" });
            man108.Models.Add(new VehicleModel() { Name = "GS450H" });
            man108.Models.Add(new VehicleModel() { Name = "IS250" });
            man108.Models.Add(new VehicleModel() { Name = "IS300h" });
            man108.Models.Add(new VehicleModel() { Name = "LS400" });
            man108.Models.Add(new VehicleModel() { Name = "LS430" });
            man108.Models.Add(new VehicleModel() { Name = "LS460" });
            man108.Models.Add(new VehicleModel() { Name = "LS600HL" });
            man108.Models.Add(new VehicleModel() { Name = "SC430" });
            mans.Add(man108);
            VehicleManufacturer man109 = new VehicleManufacturer() { Type = 1, Name = "מאזדה" };
            man109.Models = new List<VehicleModel>();
            man109.Models.Add(new VehicleModel() { Name = "121" });
            man109.Models.Add(new VehicleModel() { Name = "2" });
            man109.Models.Add(new VehicleModel() { Name = "3" });
            man109.Models.Add(new VehicleModel() { Name = "323" });
            man109.Models.Add(new VehicleModel() { Name = "323 לאנטיס" });
            man109.Models.Add(new VehicleModel() { Name = "5" });
            man109.Models.Add(new VehicleModel() { Name = "6" });
            man109.Models.Add(new VehicleModel() { Name = "626" });
            man109.Models.Add(new VehicleModel() { Name = "MPV" });
            man109.Models.Add(new VehicleModel() { Name = "MX-3" });
            man109.Models.Add(new VehicleModel() { Name = "MX-5" });
            man109.Models.Add(new VehicleModel() { Name = "MX-6" });
            man109.Models.Add(new VehicleModel() { Name = "RX-8" });
            man109.Models.Add(new VehicleModel() { Name = "דמיו" });
            man109.Models.Add(new VehicleModel() { Name = "פרמסי" });
            man109.Models.Add(new VehicleModel() { Name = "קסדוס" });
            mans.Add(man109);
            VehicleManufacturer man110 = new VehicleManufacturer() { Type = 1, Name = "מזראטי" };
            man110.Models = new List<VehicleModel>();
            man110.Models.Add(new VehicleModel() { Name = "גראן-טוריסמו" });
            man110.Models.Add(new VehicleModel() { Name = "קוואטרופורטה" });
            mans.Add(man110);
            VehicleManufacturer man111 = new VehicleManufacturer() { Type = 1, Name = "מיני" };
            man111.Models = new List<VehicleModel>();
            man111.Models.Add(new VehicleModel() { Name = "ONE" });
            man111.Models.Add(new VehicleModel() { Name = "פייסמן" });
            man111.Models.Add(new VehicleModel() { Name = "קאונטרימן" });
            man111.Models.Add(new VehicleModel() { Name = "קופה" });
            man111.Models.Add(new VehicleModel() { Name = "קופר" });
            man111.Models.Add(new VehicleModel() { Name = "קלאבמן" });
            man111.Models.Add(new VehicleModel() { Name = "רודסטר" });
            mans.Add(man111);
            VehicleManufacturer man112 = new VehicleManufacturer() { Type = 1, Name = "מיצובישי" };
            man112.Models = new List<VehicleModel>();
            man112.Models.Add(new VehicleModel() { Name = "GT3000" });
            man112.Models.Add(new VehicleModel() { Name = "I-MIEV" });
            man112.Models.Add(new VehicleModel() { Name = "אטראז'" });
            man112.Models.Add(new VehicleModel() { Name = "אקליפס" });
            man112.Models.Add(new VehicleModel() { Name = "גאלאנט" });
            man112.Models.Add(new VehicleModel() { Name = "גרנדיס" });
            man112.Models.Add(new VehicleModel() { Name = "כריזמה" });
            man112.Models.Add(new VehicleModel() { Name = "לנסר (עד 1993)" });
            man112.Models.Add(new VehicleModel() { Name = "לנסר איוולושן" });
            man112.Models.Add(new VehicleModel() { Name = "לנסר הדור החדש" });
            man112.Models.Add(new VehicleModel() { Name = "לנסר ספורטבק" });
            man112.Models.Add(new VehicleModel() { Name = "לנסר קלאסיק" });
            man112.Models.Add(new VehicleModel() { Name = "סופר לנסר" });
            man112.Models.Add(new VehicleModel() { Name = "סיגמא" });
            man112.Models.Add(new VehicleModel() { Name = "ספייס וואגן" });
            man112.Models.Add(new VehicleModel() { Name = "ספייס סטאר" });
            man112.Models.Add(new VehicleModel() { Name = "ספייס ראנר" });
            man112.Models.Add(new VehicleModel() { Name = "צ'אמפ" });
            man112.Models.Add(new VehicleModel() { Name = "קולט" });
            mans.Add(man112);
            VehicleManufacturer man113 = new VehicleManufacturer() { Type = 1, Name = "מרצדס" };
            man113.Models = new List<VehicleModel>();
            man113.Models.Add(new VehicleModel() { Name = "A-Class" });
            man113.Models.Add(new VehicleModel() { Name = "B-Class" });
            man113.Models.Add(new VehicleModel() { Name = "C-Class" });
            man113.Models.Add(new VehicleModel() { Name = "C-Class קופה" });
            man113.Models.Add(new VehicleModel() { Name = "CE" });
            man113.Models.Add(new VehicleModel() { Name = "CL" });
            man113.Models.Add(new VehicleModel() { Name = "CLA" });
            man113.Models.Add(new VehicleModel() { Name = "CLC" });
            man113.Models.Add(new VehicleModel() { Name = "CLK" });
            man113.Models.Add(new VehicleModel() { Name = "CLS" });
            man113.Models.Add(new VehicleModel() { Name = "E-Class" });
            man113.Models.Add(new VehicleModel() { Name = "E-Class קופה / קבריולט" });
            man113.Models.Add(new VehicleModel() { Name = "R-Class" });
            man113.Models.Add(new VehicleModel() { Name = "S-Class" });
            man113.Models.Add(new VehicleModel() { Name = "SE" });
            man113.Models.Add(new VehicleModel() { Name = "SL" });
            man113.Models.Add(new VehicleModel() { Name = "SLK" });
            man113.Models.Add(new VehicleModel() { Name = "SLS" });
            mans.Add(man113);
            VehicleManufacturer man114 = new VehicleManufacturer() { Type = 1, Name = "ניסאן" };
            man114.Models = new List<VehicleModel>();
            man114.Models.Add(new VehicleModel() { Name = "GT-R" });
            man114.Models.Add(new VehicleModel() { Name = "SX 200" });
            man114.Models.Add(new VehicleModel() { Name = "Z350" });
            man114.Models.Add(new VehicleModel() { Name = "Z370" });
            man114.Models.Add(new VehicleModel() { Name = "אלמרה" });
            man114.Models.Add(new VehicleModel() { Name = "אלתימה" });
            man114.Models.Add(new VehicleModel() { Name = "ג'וק JUKE" });
            man114.Models.Add(new VehicleModel() { Name = "טידה" });
            man114.Models.Add(new VehicleModel() { Name = "ליף" });
            man114.Models.Add(new VehicleModel() { Name = "מיקרה" });
            man114.Models.Add(new VehicleModel() { Name = "מקסימה" });
            man114.Models.Add(new VehicleModel() { Name = "נוט" });
            man114.Models.Add(new VehicleModel() { Name = "סאני" });
            man114.Models.Add(new VehicleModel() { Name = "פרימרה" });
            man114.Models.Add(new VehicleModel() { Name = "קווסט" });
            mans.Add(man114);
            VehicleManufacturer man115 = new VehicleManufacturer() { Type = 1, Name = "סאאב" };
            man115.Models = new List<VehicleModel>();
            man115.Models.Add(new VehicleModel() { Name = "9-3" });
            man115.Models.Add(new VehicleModel() { Name = "9-5" });
            man115.Models.Add(new VehicleModel() { Name = "900" });
            man115.Models.Add(new VehicleModel() { Name = "9000" });
            man115.Models.Add(new VehicleModel() { Name = "קונברטיבל" });
            mans.Add(man115);
            VehicleManufacturer man116 = new VehicleManufacturer() { Type = 1, Name = "סובארו" };
            man116.Models = new List<VehicleModel>();
            man116.Models.Add(new VehicleModel() { Name = "B3 האצ'בק" });
            man116.Models.Add(new VehicleModel() { Name = "B3 סדאן" });
            man116.Models.Add(new VehicleModel() { Name = "B4" });
            man116.Models.Add(new VehicleModel() { Name = "BRZ" });
            man116.Models.Add(new VehicleModel() { Name = "GLF" });
            man116.Models.Add(new VehicleModel() { Name = "SVX" });
            man116.Models.Add(new VehicleModel() { Name = "XV" });
            man116.Models.Add(new VehicleModel() { Name = "אאוטבק" });
            man116.Models.Add(new VehicleModel() { Name = "אאוטבק החדשה" });
            man116.Models.Add(new VehicleModel() { Name = "אימפרזה STi" });
            man116.Models.Add(new VehicleModel() { Name = "אימפרזה גרנד לאונה" });
            man116.Models.Add(new VehicleModel() { Name = "אימפרזה החדשה" });
            man116.Models.Add(new VehicleModel() { Name = "אימפרזה טורבו" });
            man116.Models.Add(new VehicleModel() { Name = "אימפרזה ניו אייג'" });
            man116.Models.Add(new VehicleModel() { Name = "ג'סטי" });
            man116.Models.Add(new VehicleModel() { Name = "לאונה" });
            man116.Models.Add(new VehicleModel() { Name = "לגאסי" });
            man116.Models.Add(new VehicleModel() { Name = "רקס" });
            mans.Add(man116);
            VehicleManufacturer man117 = new VehicleManufacturer() { Type = 1, Name = "סוזוקי" };
            man117.Models = new List<VehicleModel>();
            man117.Models.Add(new VehicleModel() { Name = "SX4" });
            man117.Models.Add(new VehicleModel() { Name = "איגניס" });
            man117.Models.Add(new VehicleModel() { Name = "אלטו" });
            man117.Models.Add(new VehicleModel() { Name = "בלנו" });
            man117.Models.Add(new VehicleModel() { Name = "וואגון" });
            man117.Models.Add(new VehicleModel() { Name = "ליאנה" });
            man117.Models.Add(new VehicleModel() { Name = "מרוטי" });
            man117.Models.Add(new VehicleModel() { Name = "סוויפט" });
            man117.Models.Add(new VehicleModel() { Name = "סופר בלנו" });
            man117.Models.Add(new VehicleModel() { Name = "ספלאש" });
            man117.Models.Add(new VehicleModel() { Name = "קרוסאובר" });
            mans.Add(man117);
            VehicleManufacturer man118 = new VehicleManufacturer() { Type = 1, Name = "סיאט" };
            man118.Models = new List<VehicleModel>();
            man118.Models.Add(new VehicleModel() { Name = "איביזה" });
            man118.Models.Add(new VehicleModel() { Name = "אלהמברה" });
            man118.Models.Add(new VehicleModel() { Name = "אלתיאה" });
            man118.Models.Add(new VehicleModel() { Name = "טולדו" });
            man118.Models.Add(new VehicleModel() { Name = "לאון" });
            man118.Models.Add(new VehicleModel() { Name = "מי / MII" });
            man118.Models.Add(new VehicleModel() { Name = "מלגה" });
            man118.Models.Add(new VehicleModel() { Name = "מרבלה" });
            man118.Models.Add(new VehicleModel() { Name = "קורדובה" });
            man118.Models.Add(new VehicleModel() { Name = "רונדה" });
            mans.Add(man118);
            VehicleManufacturer man119 = new VehicleManufacturer() { Type = 1, Name = "סיטרואן" };
            man119.Models = new List<VehicleModel>();
            man119.Models.Add(new VehicleModel() { Name = "AX" });
            man119.Models.Add(new VehicleModel() { Name = "BX" });
            man119.Models.Add(new VehicleModel() { Name = "C אליזה" });
            man119.Models.Add(new VehicleModel() { Name = "C-ZERO" });
            man119.Models.Add(new VehicleModel() { Name = "C1" });
            man119.Models.Add(new VehicleModel() { Name = "C15" });
            man119.Models.Add(new VehicleModel() { Name = "C2" });
            man119.Models.Add(new VehicleModel() { Name = "C3" });
            man119.Models.Add(new VehicleModel() { Name = "C3 פיקאסו" });
            man119.Models.Add(new VehicleModel() { Name = "C4" });
            man119.Models.Add(new VehicleModel() { Name = "C4 פיקאסו" });
            man119.Models.Add(new VehicleModel() { Name = "C5" });
            man119.Models.Add(new VehicleModel() { Name = "C6" });
            man119.Models.Add(new VehicleModel() { Name = "C8" });
            man119.Models.Add(new VehicleModel() { Name = "CX" });
            man119.Models.Add(new VehicleModel() { Name = "DS3" });
            man119.Models.Add(new VehicleModel() { Name = "DS4" });
            man119.Models.Add(new VehicleModel() { Name = "DS5" });
            man119.Models.Add(new VehicleModel() { Name = "XM" });
            man119.Models.Add(new VehicleModel() { Name = "ZX" });
            man119.Models.Add(new VehicleModel() { Name = "ויזה" });
            man119.Models.Add(new VehicleModel() { Name = "סקסו" });
            man119.Models.Add(new VehicleModel() { Name = "קסנטיה" });
            man119.Models.Add(new VehicleModel() { Name = "קסרה" });
            man119.Models.Add(new VehicleModel() { Name = "קסרה פיקאסו" });
            mans.Add(man119);
            VehicleManufacturer man120 = new VehicleManufacturer() { Type = 1, Name = "סמארט" };
            man120.Models = new List<VehicleModel>();
            man120.Models.Add(new VehicleModel() { Name = "פולס" });
            man120.Models.Add(new VehicleModel() { Name = "פורטו" });
            man120.Models.Add(new VehicleModel() { Name = "פיור" });
            man120.Models.Add(new VehicleModel() { Name = "פשיין" });
            man120.Models.Add(new VehicleModel() { Name = "רודסטר" });
            mans.Add(man120);
            VehicleManufacturer man121 = new VehicleManufacturer() { Type = 1, Name = "סקודה" };
            man121.Models = new List<VehicleModel>();
            man121.Models.Add(new VehicleModel() { Name = "אוקטביה" });
            man121.Models.Add(new VehicleModel() { Name = "אוקטביה קומבי" });
            man121.Models.Add(new VehicleModel() { Name = "ניו פליסיה" });
            man121.Models.Add(new VehicleModel() { Name = "סופרב" });
            man121.Models.Add(new VehicleModel() { Name = "סיטיגו / Citigo" });
            man121.Models.Add(new VehicleModel() { Name = "פאביה" });
            man121.Models.Add(new VehicleModel() { Name = "פאביה ספייס" });
            man121.Models.Add(new VehicleModel() { Name = "פורמן" });
            man121.Models.Add(new VehicleModel() { Name = "פיבוריט" });
            man121.Models.Add(new VehicleModel() { Name = "פליסיה" });
            man121.Models.Add(new VehicleModel() { Name = "ראפיד" });
            man121.Models.Add(new VehicleModel() { Name = "רומסטר" });
            mans.Add(man121);
            VehicleManufacturer man122 = new VehicleManufacturer() { Type = 1, Name = "פולקסווגן" };
            man122.Models = new List<VehicleModel>();
            man122.Models.Add(new VehicleModel() { Name = "איוס" });
            man122.Models.Add(new VehicleModel() { Name = "אפ / UP" });
            man122.Models.Add(new VehicleModel() { Name = "בורה" });
            man122.Models.Add(new VehicleModel() { Name = "ג'טה" });
            man122.Models.Add(new VehicleModel() { Name = "גולף" });
            man122.Models.Add(new VehicleModel() { Name = "גולף GTI" });
            man122.Models.Add(new VehicleModel() { Name = "גולף פלוס" });
            man122.Models.Add(new VehicleModel() { Name = "דרבי" });
            man122.Models.Add(new VehicleModel() { Name = "ונטו" });
            man122.Models.Add(new VehicleModel() { Name = "חיפושית" });
            man122.Models.Add(new VehicleModel() { Name = "חיפושית החדשה" });
            man122.Models.Add(new VehicleModel() { Name = "טוראן" });
            man122.Models.Add(new VehicleModel() { Name = "פאסאט" });
            man122.Models.Add(new VehicleModel() { Name = "פאסאט CC" });
            man122.Models.Add(new VehicleModel() { Name = "פולו" });
            man122.Models.Add(new VehicleModel() { Name = "פולו קלאסיק" });
            man122.Models.Add(new VehicleModel() { Name = "פייטון" });
            man122.Models.Add(new VehicleModel() { Name = "קוראדו" });
            man122.Models.Add(new VehicleModel() { Name = "שירוקו" });
            mans.Add(man122);
            VehicleManufacturer man123 = new VehicleManufacturer() { Type = 1, Name = "פונטיאק" };
            man123.Models = new List<VehicleModel>();
            man123.Models.Add(new VehicleModel() { Name = "G-6" });
            man123.Models.Add(new VehicleModel() { Name = "LE 6000" });
            man123.Models.Add(new VehicleModel() { Name = "בונוביל" });
            man123.Models.Add(new VehicleModel() { Name = "גרנד אם" });
            man123.Models.Add(new VehicleModel() { Name = "גרנד פרי" });
            man123.Models.Add(new VehicleModel() { Name = "טמפסט" });
            man123.Models.Add(new VehicleModel() { Name = "טרנס אם" });
            man123.Models.Add(new VehicleModel() { Name = "סולסטיס" });
            man123.Models.Add(new VehicleModel() { Name = "סנברד" });
            man123.Models.Add(new VehicleModel() { Name = "פיירבירד" });
            mans.Add(man123);
            VehicleManufacturer man124 = new VehicleManufacturer() { Type = 1, Name = "פורד" };
            man124.Models = new List<VehicleModel>();
            man124.Models.Add(new VehicleModel() { Name = "GT" });
            man124.Models.Add(new VehicleModel() { Name = "tourer" });
            man124.Models.Add(new VehicleModel() { Name = "אוריון" });
            man124.Models.Add(new VehicleModel() { Name = "אס-מקס" });
            man124.Models.Add(new VehicleModel() { Name = "אסקורט" });
            man124.Models.Add(new VehicleModel() { Name = "ברבי" });
            man124.Models.Add(new VehicleModel() { Name = "ברנדה" });
            man124.Models.Add(new VehicleModel() { Name = "גלאקסי" });
            man124.Models.Add(new VehicleModel() { Name = "וינדסטאר" });
            man124.Models.Add(new VehicleModel() { Name = "טאורוס" });
            man124.Models.Add(new VehicleModel() { Name = "טנדרבירד" });
            man124.Models.Add(new VehicleModel() { Name = "טרייסר" });
            man124.Models.Add(new VehicleModel() { Name = "מונדאו" });
            man124.Models.Add(new VehicleModel() { Name = "מוסטנג" });
            man124.Models.Add(new VehicleModel() { Name = "מרקורי" });
            man124.Models.Add(new VehicleModel() { Name = "סיירה" });
            man124.Models.Add(new VehicleModel() { Name = "סקורפיו" });
            man124.Models.Add(new VehicleModel() { Name = "פוקוס" });
            man124.Models.Add(new VehicleModel() { Name = "פיאסטה" });
            man124.Models.Add(new VehicleModel() { Name = "קונקט" });
            man124.Models.Add(new VehicleModel() { Name = "קורטינה" });
            mans.Add(man124);
            VehicleManufacturer man125 = new VehicleManufacturer() { Type = 1, Name = "פורשה" };
            man125.Models = new List<VehicleModel>();
            man125.Models.Add(new VehicleModel() { Name = "911 קאררה" });
            man125.Models.Add(new VehicleModel() { Name = "בוקסטר" });
            man125.Models.Add(new VehicleModel() { Name = "פאנאמרה" });
            man125.Models.Add(new VehicleModel() { Name = "קאיימן" });
            mans.Add(man125);
            VehicleManufacturer man126 = new VehicleManufacturer() { Type = 1, Name = "פיאט" };
            man126.Models = new List<VehicleModel>();
            man126.Models.Add(new VehicleModel() { Name = "127" });
            man126.Models.Add(new VehicleModel() { Name = "131" });
            man126.Models.Add(new VehicleModel() { Name = "132" });
            man126.Models.Add(new VehicleModel() { Name = "500" });
            man126.Models.Add(new VehicleModel() { Name = "500C" });
            man126.Models.Add(new VehicleModel() { Name = "500L" });
            man126.Models.Add(new VehicleModel() { Name = "אברת' / ABARTH" });
            man126.Models.Add(new VehicleModel() { Name = "אונו" });
            man126.Models.Add(new VehicleModel() { Name = "אונו סיליקטה" });
            man126.Models.Add(new VehicleModel() { Name = "בראבה" });
            man126.Models.Add(new VehicleModel() { Name = "בראבו" });
            man126.Models.Add(new VehicleModel() { Name = "דונה" });
            man126.Models.Add(new VehicleModel() { Name = "טיפו" });
            man126.Models.Add(new VehicleModel() { Name = "טמפרה" });
            man126.Models.Add(new VehicleModel() { Name = "כרומה" });
            man126.Models.Add(new VehicleModel() { Name = "מולטיפלה" });
            man126.Models.Add(new VehicleModel() { Name = "מריאה" });
            man126.Models.Add(new VehicleModel() { Name = "סדיצ'י" });
            man126.Models.Add(new VehicleModel() { Name = "סקודו" });
            man126.Models.Add(new VehicleModel() { Name = "פונטו" });
            man126.Models.Add(new VehicleModel() { Name = "פונטו איבו" });
            man126.Models.Add(new VehicleModel() { Name = "פונטו גרנדה" });
            man126.Models.Add(new VehicleModel() { Name = "פונטו ספייס" });
            man126.Models.Add(new VehicleModel() { Name = "פנדה" });
            man126.Models.Add(new VehicleModel() { Name = "קובו / QUBO" });
            man126.Models.Add(new VehicleModel() { Name = "קופה" });
            man126.Models.Add(new VehicleModel() { Name = "רגאטה" });
            man126.Models.Add(new VehicleModel() { Name = "ריטמו" });
            mans.Add(man126);
            VehicleManufacturer man127 = new VehicleManufacturer() { Type = 1, Name = "פיג'ו" };
            man127.Models = new List<VehicleModel>();
            man127.Models.Add(new VehicleModel() { Name = "104" });
            man127.Models.Add(new VehicleModel() { Name = "106" });
            man127.Models.Add(new VehicleModel() { Name = "107" });
            man127.Models.Add(new VehicleModel() { Name = "204" });
            man127.Models.Add(new VehicleModel() { Name = "205" });
            man127.Models.Add(new VehicleModel() { Name = "206" });
            man127.Models.Add(new VehicleModel() { Name = "206 +" });
            man127.Models.Add(new VehicleModel() { Name = "207" });
            man127.Models.Add(new VehicleModel() { Name = "208" });
            man127.Models.Add(new VehicleModel() { Name = "208 GTI" });
            man127.Models.Add(new VehicleModel() { Name = "3008" });
            man127.Models.Add(new VehicleModel() { Name = "301" });
            man127.Models.Add(new VehicleModel() { Name = "305" });
            man127.Models.Add(new VehicleModel() { Name = "306" });
            man127.Models.Add(new VehicleModel() { Name = "307" });
            man127.Models.Add(new VehicleModel() { Name = "308" });
            man127.Models.Add(new VehicleModel() { Name = "308CC" });
            man127.Models.Add(new VehicleModel() { Name = "309" });
            man127.Models.Add(new VehicleModel() { Name = "405" });
            man127.Models.Add(new VehicleModel() { Name = "406" });
            man127.Models.Add(new VehicleModel() { Name = "407" });
            man127.Models.Add(new VehicleModel() { Name = "5008" });
            man127.Models.Add(new VehicleModel() { Name = "504" });
            man127.Models.Add(new VehicleModel() { Name = "505" });
            man127.Models.Add(new VehicleModel() { Name = "508" });
            man127.Models.Add(new VehicleModel() { Name = "605" });
            man127.Models.Add(new VehicleModel() { Name = "607" });
            man127.Models.Add(new VehicleModel() { Name = "iON" });
            man127.Models.Add(new VehicleModel() { Name = "RCZ" });
            mans.Add(man127);
            VehicleManufacturer man128 = new VehicleManufacturer() { Type = 1, Name = "פרארי" };
            man128.Models = new List<VehicleModel>();
            man128.Models.Add(new VehicleModel() { Name = "458" });
            man128.Models.Add(new VehicleModel() { Name = "FF" });
            man128.Models.Add(new VehicleModel() { Name = "קליפורניה" });
            mans.Add(man128);
            VehicleManufacturer man129 = new VehicleManufacturer() { Type = 1, Name = "קדילאק" };
            man129.Models = new List<VehicleModel>();
            man129.Models.Add(new VehicleModel() { Name = "ATS" });
            man129.Models.Add(new VehicleModel() { Name = "CTS" });
            man129.Models.Add(new VehicleModel() { Name = "XLR" });
            man129.Models.Add(new VehicleModel() { Name = "STS" });
            man129.Models.Add(new VehicleModel() { Name = "סוויל" });
            man129.Models.Add(new VehicleModel() { Name = "דוויל" });
            mans.Add(man129);
            VehicleManufacturer man130 = new VehicleManufacturer() { Type = 1, Name = "קיה" };
            man130.Models = new List<VehicleModel>();
            man130.Models.Add(new VehicleModel() { Name = "אופטימה / Optima" });
            man130.Models.Add(new VehicleModel() { Name = "אופירוס" });
            man130.Models.Add(new VehicleModel() { Name = "ג'ויס" });
            man130.Models.Add(new VehicleModel() { Name = "לאו" });
            man130.Models.Add(new VehicleModel() { Name = "מג'נטיס" });
            man130.Models.Add(new VehicleModel() { Name = "מנטור" });
            man130.Models.Add(new VehicleModel() { Name = "סול" });
            man130.Models.Add(new VehicleModel() { Name = "סיד" });
            man130.Models.Add(new VehicleModel() { Name = "ספיה" });
            man130.Models.Add(new VehicleModel() { Name = "סראטו" });
            man130.Models.Add(new VehicleModel() { Name = "פורטה" });
            man130.Models.Add(new VehicleModel() { Name = "פיקנטו" });
            man130.Models.Add(new VehicleModel() { Name = "פרייד" });
            man130.Models.Add(new VehicleModel() { Name = "קארנס" });
            man130.Models.Add(new VehicleModel() { Name = "קלארוס" });
            man130.Models.Add(new VehicleModel() { Name = "קריאטו" });
            man130.Models.Add(new VehicleModel() { Name = "קרניבל" });
            man130.Models.Add(new VehicleModel() { Name = "ריו" });
            man130.Models.Add(new VehicleModel() { Name = "שומה" });
            mans.Add(man130);
            VehicleManufacturer man131 = new VehicleManufacturer() { Type = 1, Name = "קרייזלר" };
            man131.Models = new List<VehicleModel>();
            man131.Models.Add(new VehicleModel() { Name = "300C" });
            man131.Models.Add(new VehicleModel() { Name = "300C SRT" });
            man131.Models.Add(new VehicleModel() { Name = "300M" });
            man131.Models.Add(new VehicleModel() { Name = "אמפריאל" });
            man131.Models.Add(new VehicleModel() { Name = "גראנד וויאג'ר" });
            man131.Models.Add(new VehicleModel() { Name = "וויאג'ר" });
            man131.Models.Add(new VehicleModel() { Name = "ויזן" });
            man131.Models.Add(new VehicleModel() { Name = "נאון" });
            man131.Models.Add(new VehicleModel() { Name = "סברינג" });
            man131.Models.Add(new VehicleModel() { Name = "סטרטוס" });
            man131.Models.Add(new VehicleModel() { Name = "סרטוגה" });
            man131.Models.Add(new VehicleModel() { Name = "קרוזר" });
            man131.Models.Add(new VehicleModel() { Name = "קרוספייר" });
            mans.Add(man131);
            VehicleManufacturer man132 = new VehicleManufacturer() { Type = 1, Name = "רובר" };
            man132.Models = new List<VehicleModel>();
            man132.Models.Add(new VehicleModel() { Name = "214" });
            man132.Models.Add(new VehicleModel() { Name = "216" });
            man132.Models.Add(new VehicleModel() { Name = "414" });
            man132.Models.Add(new VehicleModel() { Name = "416" });
            man132.Models.Add(new VehicleModel() { Name = "420" });
            man132.Models.Add(new VehicleModel() { Name = "600" });
            man132.Models.Add(new VehicleModel() { Name = "620" });
            man132.Models.Add(new VehicleModel() { Name = "623" });
            man132.Models.Add(new VehicleModel() { Name = "825" });
            man132.Models.Add(new VehicleModel() { Name = "827" });
            man132.Models.Add(new VehicleModel() { Name = "MG VVC" });
            man132.Models.Add(new VehicleModel() { Name = "MG ZR" });
            man132.Models.Add(new VehicleModel() { Name = "MG ZS" });
            man132.Models.Add(new VehicleModel() { Name = "MG ZT" });
            man132.Models.Add(new VehicleModel() { Name = "MGF" });
            man132.Models.Add(new VehicleModel() { Name = "R25" });
            man132.Models.Add(new VehicleModel() { Name = "R45" });
            man132.Models.Add(new VehicleModel() { Name = "R75" });
            mans.Add(man132);
            VehicleManufacturer man133 = new VehicleManufacturer() { Type = 1, Name = "רנו" };
            man133.Models = new List<VehicleModel>();
            man133.Models.Add(new VehicleModel() { Name = "11" });
            man133.Models.Add(new VehicleModel() { Name = "18" });
            man133.Models.Add(new VehicleModel() { Name = "19" });
            man133.Models.Add(new VehicleModel() { Name = "21" });
            man133.Models.Add(new VehicleModel() { Name = "25" });
            man133.Models.Add(new VehicleModel() { Name = "4" });
            man133.Models.Add(new VehicleModel() { Name = "5" });
            man133.Models.Add(new VehicleModel() { Name = "9" });
            man133.Models.Add(new VehicleModel() { Name = "גרנד סניק" });
            man133.Models.Add(new VehicleModel() { Name = "וול-סאטיס" });
            man133.Models.Add(new VehicleModel() { Name = "טווינגו" });
            man133.Models.Add(new VehicleModel() { Name = "טליה" });
            man133.Models.Add(new VehicleModel() { Name = "לגונה" });
            man133.Models.Add(new VehicleModel() { Name = "לוגאן MCV" });
            man133.Models.Add(new VehicleModel() { Name = "לטיטוד" });
            man133.Models.Add(new VehicleModel() { Name = "מגאן I" });
            man133.Models.Add(new VehicleModel() { Name = "מגאן II" });
            man133.Models.Add(new VehicleModel() { Name = "מגאן החדשה" });
            man133.Models.Add(new VehicleModel() { Name = "מגאן קופה / ספורט" });
            man133.Models.Add(new VehicleModel() { Name = "סימבול" });
            man133.Models.Add(new VehicleModel() { Name = "סניק I" });
            man133.Models.Add(new VehicleModel() { Name = "סניק II" });
            man133.Models.Add(new VehicleModel() { Name = "סניק III" });
            man133.Models.Add(new VehicleModel() { Name = "ספרן" });
            man133.Models.Add(new VehicleModel() { Name = "פלואנס" });
            man133.Models.Add(new VehicleModel() { Name = "פלואנס חשמלי" });
            man133.Models.Add(new VehicleModel() { Name = "קליאו B" });
            man133.Models.Add(new VehicleModel() { Name = "קליאו B II" });
            man133.Models.Add(new VehicleModel() { Name = "קליאו I" });
            man133.Models.Add(new VehicleModel() { Name = "קליאו III" });
            man133.Models.Add(new VehicleModel() { Name = "קליאו החדשה" });
            man133.Models.Add(new VehicleModel() { Name = "קפצ'ור" });
            mans.Add(man133);
            VehicleManufacturer man134 = new VehicleManufacturer() { Type = 1, Name = "שברולט" };
            man134.Models = new List<VehicleModel>();
            man134.Models.Add(new VehicleModel() { Name = "אבאו" });
            man134.Models.Add(new VehicleModel() { Name = "אופטרה" });
            man134.Models.Add(new VehicleModel() { Name = "אורלנדו" });
            man134.Models.Add(new VehicleModel() { Name = "אימפלה" });
            man134.Models.Add(new VehicleModel() { Name = "אלרו" });
            man134.Models.Add(new VehicleModel() { Name = "אפיקה" });
            man134.Models.Add(new VehicleModel() { Name = "ברטה" });
            man134.Models.Add(new VehicleModel() { Name = "וולט" });
            man134.Models.Add(new VehicleModel() { Name = "ויואנט" });
            man134.Models.Add(new VehicleModel() { Name = "לומינה" });
            man134.Models.Add(new VehicleModel() { Name = "מאליבו" });
            man134.Models.Add(new VehicleModel() { Name = "מונטה קרלו" });
            man134.Models.Add(new VehicleModel() { Name = "סוניק" });
            man134.Models.Add(new VehicleModel() { Name = "סיליבריטי" });
            man134.Models.Add(new VehicleModel() { Name = "ספארק" });
            man134.Models.Add(new VehicleModel() { Name = "קאמארו" });
            man134.Models.Add(new VehicleModel() { Name = "קוואליר" });
            man134.Models.Add(new VehicleModel() { Name = "קורבט" });
            man134.Models.Add(new VehicleModel() { Name = "קורבט Z06" });
            man134.Models.Add(new VehicleModel() { Name = "קורסיקה" });
            man134.Models.Add(new VehicleModel() { Name = "קפריס" });
            man134.Models.Add(new VehicleModel() { Name = "קרוז" });
            mans.Add(man134);
            VehicleManufacturer man135 = new VehicleManufacturer() { Type = 1, Name = "מחפש!" };
            man135.Models = new List<VehicleModel>();
            man135.Models.Add(new VehicleModel() { Name = "מחפש רכב" });
            mans.Add(man135);
            VehicleManufacturer man136 = new VehicleManufacturer() { Type = 3, Name = "אאודי" };
            man136.Models = new List<VehicleModel>();
            man136.Models.Add(new VehicleModel() { Name = "Q3" });
            man136.Models.Add(new VehicleModel() { Name = "Q5" });
            man136.Models.Add(new VehicleModel() { Name = "Q7" });
            mans.Add(man136);
            VehicleManufacturer man137 = new VehicleManufacturer() { Type = 3, Name = "אופל" };
            man137.Models = new List<VehicleModel>();
            man137.Models.Add(new VehicleModel() { Name = "פרונטרה" });
            mans.Add(man137);
            VehicleManufacturer man138 = new VehicleManufacturer() { Type = 3, Name = "אינפיניטי" };
            man138.Models = new List<VehicleModel>();
            man138.Models.Add(new VehicleModel() { Name = "EX37" });
            man138.Models.Add(new VehicleModel() { Name = "FX30 D" });
            man138.Models.Add(new VehicleModel() { Name = "FX35" });
            man138.Models.Add(new VehicleModel() { Name = "FX37" });
            man138.Models.Add(new VehicleModel() { Name = "FX45" });
            man138.Models.Add(new VehicleModel() { Name = "FX50" });
            mans.Add(man138);
            VehicleManufacturer man139 = new VehicleManufacturer() { Type = 3, Name = "איסוזו" };
            man139.Models = new List<VehicleModel>();
            man139.Models.Add(new VehicleModel() { Name = "טרופר ארוך" });
            man139.Models.Add(new VehicleModel() { Name = "טרופר קצר" });
            man139.Models.Add(new VehicleModel() { Name = "סומו" });
            man139.Models.Add(new VehicleModel() { Name = "רודאו" });
            mans.Add(man139);
            VehicleManufacturer man140 = new VehicleManufacturer() { Type = 3, Name = "ב מ וו" };
            man140.Models = new List<VehicleModel>();
            man140.Models.Add(new VehicleModel() { Name = "X1" });
            man140.Models.Add(new VehicleModel() { Name = "X3" });
            man140.Models.Add(new VehicleModel() { Name = "X5" });
            man140.Models.Add(new VehicleModel() { Name = "X6" });
            mans.Add(man140);
            VehicleManufacturer man141 = new VehicleManufacturer() { Type = 3, Name = "ביואיק" };
            man141.Models = new List<VehicleModel>();
            man141.Models.Add(new VehicleModel() { Name = "אינקלייב" });
            man141.Models.Add(new VehicleModel() { Name = "רנדוו" });
            mans.Add(man141);
            VehicleManufacturer man142 = new VehicleManufacturer() { Type = 3, Name = "ג'י.אם.סי / GMC" };
            man142.Models = new List<VehicleModel>();
            man142.Models.Add(new VehicleModel() { Name = "אינווי" });
            man142.Models.Add(new VehicleModel() { Name = "אקדיה" });
            man142.Models.Add(new VehicleModel() { Name = "ג'ימי" });
            man142.Models.Add(new VehicleModel() { Name = "יוקון" });
            man142.Models.Add(new VehicleModel() { Name = "סאברבן" });
            mans.Add(man142);
            VehicleManufacturer man143 = new VehicleManufacturer() { Type = 3, Name = "ג'יפ תע''ר" };
            man143.Models = new List<VehicleModel>();
            man143.Models.Add(new VehicleModel() { Name = "סופה" });
            man143.Models.Add(new VehicleModel() { Name = "סופה פתוח" });
            mans.Add(man143);
            VehicleManufacturer man144 = new VehicleManufacturer() { Type = 3, Name = "גי'פ / Jeep" };
            man144.Models = new List<VehicleModel>();
            man144.Models.Add(new VehicleModel() { Name = "גרנד צ'ירוקי (עד 2004)" });
            man144.Models.Add(new VehicleModel() { Name = "גרנד צ'ירוקי החדשה" });
            man144.Models.Add(new VehicleModel() { Name = "ליברטי" });
            man144.Models.Add(new VehicleModel() { Name = "סהרה קצר" });
            man144.Models.Add(new VehicleModel() { Name = "סי ג'יי" });
            man144.Models.Add(new VehicleModel() { Name = "פטריוט" });
            man144.Models.Add(new VehicleModel() { Name = "צ'ירוקי" });
            man144.Models.Add(new VehicleModel() { Name = "קומנדר" });
            man144.Models.Add(new VehicleModel() { Name = "קומפאס" });
            man144.Models.Add(new VehicleModel() { Name = "רנגלר ארוך" });
            man144.Models.Add(new VehicleModel() { Name = "רנגלר סהרה" });
            man144.Models.Add(new VehicleModel() { Name = "רנגלר קצר" });
            man144.Models.Add(new VehicleModel() { Name = "רנגלר רוביקון" });
            mans.Add(man144);
            VehicleManufacturer man145 = new VehicleManufacturer() { Type = 3, Name = "דודג'" };
            man145.Models = new List<VehicleModel>();
            man145.Models.Add(new VehicleModel() { Name = "דורנגו" });
            man145.Models.Add(new VehicleModel() { Name = "ניטרו" });
            mans.Add(man145);
            VehicleManufacturer man146 = new VehicleManufacturer() { Type = 3, Name = "דייהטסו" };
            man146.Models = new List<VehicleModel>();
            man146.Models.Add(new VehicleModel() { Name = "טריוס" });
            man146.Models.Add(new VehicleModel() { Name = "פרוזה" });
            mans.Add(man146);
            VehicleManufacturer man147 = new VehicleManufacturer() { Type = 3, Name = "האמר" };
            man147.Models = new List<VehicleModel>();
            man147.Models.Add(new VehicleModel() { Name = "H1" });
            man147.Models.Add(new VehicleModel() { Name = "H2" });
            man147.Models.Add(new VehicleModel() { Name = "H3" });
            mans.Add(man147);
            VehicleManufacturer man148 = new VehicleManufacturer() { Type = 3, Name = "הונדה" };
            man148.Models = new List<VehicleModel>();
            man148.Models.Add(new VehicleModel() { Name = "CR-V" });
            man148.Models.Add(new VehicleModel() { Name = "HR-V" });
            mans.Add(man148);
            VehicleManufacturer man149 = new VehicleManufacturer() { Type = 3, Name = "וולוו" };
            man149.Models = new List<VehicleModel>();
            man149.Models.Add(new VehicleModel() { Name = "XC60" });
            man149.Models.Add(new VehicleModel() { Name = "XC90" });
            mans.Add(man149);
            VehicleManufacturer man150 = new VehicleManufacturer() { Type = 3, Name = "טאטא" };
            man150.Models = new List<VehicleModel>();
            man150.Models.Add(new VehicleModel() { Name = "סהרה" });
            man150.Models.Add(new VehicleModel() { Name = "סומו" });
            man150.Models.Add(new VehicleModel() { Name = "סיירה" });
            man150.Models.Add(new VehicleModel() { Name = "ספארי" });
            mans.Add(man150);
            VehicleManufacturer man151 = new VehicleManufacturer() { Type = 3, Name = "טויוטה" };
            man151.Models = new List<VehicleModel>();
            man151.Models.Add(new VehicleModel() { Name = "4RUNNER" });
            man151.Models.Add(new VehicleModel() { Name = "FJ קרוזר" });
            man151.Models.Add(new VehicleModel() { Name = "RAV4 ארוך" });
            man151.Models.Add(new VehicleModel() { Name = "RAV4 קצר" });
            man151.Models.Add(new VehicleModel() { Name = "היילנדר" });
            man151.Models.Add(new VehicleModel() { Name = "וונזה" });
            man151.Models.Add(new VehicleModel() { Name = "לנד קרוזר V8" });
            man151.Models.Add(new VehicleModel() { Name = "לנד קרוזר ארוך" });
            man151.Models.Add(new VehicleModel() { Name = "לנד קרוזר סדרה 70" });
            man151.Models.Add(new VehicleModel() { Name = "לנד קרוזר פרדו ארוך" });
            man151.Models.Add(new VehicleModel() { Name = "לנד קרוזר פרדו קצר" });
            man151.Models.Add(new VehicleModel() { Name = "לנד קרוזר קצר" });
            man151.Models.Add(new VehicleModel() { Name = "סקויה" });
            mans.Add(man151);
            VehicleManufacturer man152 = new VehicleManufacturer() { Type = 3, Name = "יונדאי" };
            man152.Models = new List<VehicleModel>();
            man152.Models.Add(new VehicleModel() { Name = "iX35" });
            man152.Models.Add(new VehicleModel() { Name = "iX55" });
            man152.Models.Add(new VehicleModel() { Name = "גאלופר ארוך" });
            man152.Models.Add(new VehicleModel() { Name = "גאלופר קצר" });
            man152.Models.Add(new VehicleModel() { Name = "טאראקן" });
            man152.Models.Add(new VehicleModel() { Name = "טוסון" });
            man152.Models.Add(new VehicleModel() { Name = "סנטה פה" });
            mans.Add(man152);
            VehicleManufacturer man153 = new VehicleManufacturer() { Type = 3, Name = "לאדה" };
            man153.Models = new List<VehicleModel>();
            man153.Models.Add(new VehicleModel() { Name = "ויליג'" });
            man153.Models.Add(new VehicleModel() { Name = "ניבה" });
            mans.Add(man153);
            VehicleManufacturer man154 = new VehicleManufacturer() { Type = 3, Name = "לינקולן" };
            man154.Models = new List<VehicleModel>();
            man154.Models.Add(new VehicleModel() { Name = "MKC" });
            man154.Models.Add(new VehicleModel() { Name = "MKT" });
            man154.Models.Add(new VehicleModel() { Name = "MKX" });
            man154.Models.Add(new VehicleModel() { Name = "אביאטור" });
            man154.Models.Add(new VehicleModel() { Name = "נביגטור" });
            mans.Add(man154);
            VehicleManufacturer man155 = new VehicleManufacturer() { Type = 3, Name = "לנד רובר" };
            man155.Models = new List<VehicleModel>();
            man155.Models.Add(new VehicleModel() { Name = "דיסקברי 1" });
            man155.Models.Add(new VehicleModel() { Name = "דיסקברי 2" });
            man155.Models.Add(new VehicleModel() { Name = "דיסקברי 3" });
            man155.Models.Add(new VehicleModel() { Name = "דיסקברי 4" });
            man155.Models.Add(new VehicleModel() { Name = "דיפנדר" });
            man155.Models.Add(new VehicleModel() { Name = "פרילנדר 1" });
            man155.Models.Add(new VehicleModel() { Name = "פרילנדר 2" });
            man155.Models.Add(new VehicleModel() { Name = "ריינג' רובר" });
            man155.Models.Add(new VehicleModel() { Name = "ריינג' רובר איווק" });
            man155.Models.Add(new VehicleModel() { Name = "ריינג' רובר ספורט" });
            mans.Add(man155);
            VehicleManufacturer man156 = new VehicleManufacturer() { Type = 3, Name = "לקסוס" };
            man156.Models = new List<VehicleModel>();
            man156.Models.Add(new VehicleModel() { Name = "GX470" });
            man156.Models.Add(new VehicleModel() { Name = "RX350" });
            man156.Models.Add(new VehicleModel() { Name = "RX400h" });
            man156.Models.Add(new VehicleModel() { Name = "RX450H" });
            mans.Add(man156);
            VehicleManufacturer man157 = new VehicleManufacturer() { Type = 3, Name = "מאזדה" };
            man157.Models = new List<VehicleModel>();
            man157.Models.Add(new VehicleModel() { Name = "CX-07" });
            man157.Models.Add(new VehicleModel() { Name = "CX-09" });
            man157.Models.Add(new VehicleModel() { Name = "CX-5" });
            man157.Models.Add(new VehicleModel() { Name = "טריביוט" });
            mans.Add(man157);
            VehicleManufacturer man158 = new VehicleManufacturer() { Type = 3, Name = "מיצובישי" };
            man158.Models = new List<VehicleModel>();
            man158.Models.Add(new VehicleModel() { Name = "ASX" });
            man158.Models.Add(new VehicleModel() { Name = "אאוטלנדר" });
            man158.Models.Add(new VehicleModel() { Name = "פאג'רו ספורט" });
            man158.Models.Add(new VehicleModel() { Name = "פג'רו ארוך" });
            man158.Models.Add(new VehicleModel() { Name = "פג'רו קצר" });
            mans.Add(man158);
            VehicleManufacturer man159 = new VehicleManufacturer() { Type = 3, Name = "מרצדס" };
            man159.Models = new List<VehicleModel>();
            man159.Models.Add(new VehicleModel() { Name = "G Class" });
            man159.Models.Add(new VehicleModel() { Name = "GL Class" });
            man159.Models.Add(new VehicleModel() { Name = "GLK Class" });
            man159.Models.Add(new VehicleModel() { Name = "ML Class" });
            mans.Add(man159);
            VehicleManufacturer man160 = new VehicleManufacturer() { Type = 3, Name = "ניסאן" };
            man160.Models = new List<VehicleModel>();
            man160.Models.Add(new VehicleModel() { Name = "אקס טרה" });
            man160.Models.Add(new VehicleModel() { Name = "אקס טרייל" });
            man160.Models.Add(new VehicleModel() { Name = "ארמדה" });
            man160.Models.Add(new VehicleModel() { Name = "טראנו ארוך" });
            man160.Models.Add(new VehicleModel() { Name = "טראנו קצר" });
            man160.Models.Add(new VehicleModel() { Name = "מוראנו" });
            man160.Models.Add(new VehicleModel() { Name = "פאת'פיינדר" });
            man160.Models.Add(new VehicleModel() { Name = "פטרול" });
            man160.Models.Add(new VehicleModel() { Name = "קשקאי" });
            man160.Models.Add(new VehicleModel() { Name = "קשקאי פלוס 2" });
            mans.Add(man160);
            VehicleManufacturer man161 = new VehicleManufacturer() { Type = 3, Name = "סאנגיונג" };
            man161.Models = new List<VehicleModel>();
            man161.Models.Add(new VehicleModel() { Name = "אקטיון" });
            man161.Models.Add(new VehicleModel() { Name = "מוסו" });
            man161.Models.Add(new VehicleModel() { Name = "קורנדו" });
            man161.Models.Add(new VehicleModel() { Name = "קיירון" });
            man161.Models.Add(new VehicleModel() { Name = "רקסטון" });
            mans.Add(man161);
            VehicleManufacturer man162 = new VehicleManufacturer() { Type = 3, Name = "סובארו" };
            man162.Models = new List<VehicleModel>();
            man162.Models.Add(new VehicleModel() { Name = "B9 טריבקה" });
            man162.Models.Add(new VehicleModel() { Name = "פורסטר" });
            mans.Add(man162);
            VehicleManufacturer man163 = new VehicleManufacturer() { Type = 3, Name = "סוזוקי" };
            man163.Models = new List<VehicleModel>();
            man163.Models.Add(new VehicleModel() { Name = "X90" });
            man163.Models.Add(new VehicleModel() { Name = "XL7" });
            man163.Models.Add(new VehicleModel() { Name = "ג'ימני" });
            man163.Models.Add(new VehicleModel() { Name = "גרנד ויטרה" });
            man163.Models.Add(new VehicleModel() { Name = "ויטרה" });
            man163.Models.Add(new VehicleModel() { Name = "סמוראי" });
            mans.Add(man163);
            VehicleManufacturer man164 = new VehicleManufacturer() { Type = 3, Name = "סיטרואן" };
            man164.Models = new List<VehicleModel>();
            man164.Models.Add(new VehicleModel() { Name = "C-CROSSER" });
            mans.Add(man164);
            VehicleManufacturer man165 = new VehicleManufacturer() { Type = 3, Name = "סקודה" };
            man165.Models = new List<VehicleModel>();
            man165.Models.Add(new VehicleModel() { Name = "ייטי" });
            mans.Add(man165);
            VehicleManufacturer man166 = new VehicleManufacturer() { Type = 3, Name = "פולקסווגן" };
            man166.Models = new List<VehicleModel>();
            man166.Models.Add(new VehicleModel() { Name = "טוארג" });
            man166.Models.Add(new VehicleModel() { Name = "טיגואן" });
            mans.Add(man166);
            VehicleManufacturer man167 = new VehicleManufacturer() { Type = 3, Name = "פורד" };
            man167.Models = new List<VehicleModel>();
            man167.Models.Add(new VehicleModel() { Name = "Excursion" });
            man167.Models.Add(new VehicleModel() { Name = "אדג'" });
            man167.Models.Add(new VehicleModel() { Name = "אסקייפ" });
            man167.Models.Add(new VehicleModel() { Name = "אקספדישן" });
            man167.Models.Add(new VehicleModel() { Name = "אקספלורר" });
            man167.Models.Add(new VehicleModel() { Name = "קוגה" });
            mans.Add(man167);
            VehicleManufacturer man168 = new VehicleManufacturer() { Type = 3, Name = "פורשה" };
            man168.Models = new List<VehicleModel>();
            man168.Models.Add(new VehicleModel() { Name = "קאיין" });
            mans.Add(man168);
            VehicleManufacturer man169 = new VehicleManufacturer() { Type = 3, Name = "פיג'ו" };
            man169.Models = new List<VehicleModel>();
            man169.Models.Add(new VehicleModel() { Name = "2008" });
            mans.Add(man169);
            VehicleManufacturer man170 = new VehicleManufacturer() { Type = 3, Name = "קדילאק" };
            man170.Models = new List<VehicleModel>();
            man170.Models.Add(new VehicleModel() { Name = "SRX" });
            man170.Models.Add(new VehicleModel() { Name = "אסקלייד" });
            mans.Add(man170);
            VehicleManufacturer man171 = new VehicleManufacturer() { Type = 3, Name = "קיה" };
            man171.Models = new List<VehicleModel>();
            man171.Models.Add(new VehicleModel() { Name = "בורנגו" });
            man171.Models.Add(new VehicleModel() { Name = "סורנטו" });
            man171.Models.Add(new VehicleModel() { Name = "ספורטז'" });
            mans.Add(man171);
            VehicleManufacturer man172 = new VehicleManufacturer() { Type = 3, Name = "רנו" };
            man172.Models = new List<VehicleModel>();
            man172.Models.Add(new VehicleModel() { Name = "קוליאוס" });
            mans.Add(man172);
            VehicleManufacturer man173 = new VehicleManufacturer() { Type = 3, Name = "שברולט" };
            man173.Models = new List<VehicleModel>();
            man173.Models.Add(new VehicleModel() { Name = "אפלנדר" });
            man173.Models.Add(new VehicleModel() { Name = "בלייזר" });
            man173.Models.Add(new VehicleModel() { Name = "טאהו / יוקון" });
            man173.Models.Add(new VehicleModel() { Name = "טראוורס" });
            man173.Models.Add(new VehicleModel() { Name = "טראקס" });
            man173.Models.Add(new VehicleModel() { Name = "טרייל בלייזר" });
            man173.Models.Add(new VehicleModel() { Name = "סוברבן" });
            man173.Models.Add(new VehicleModel() { Name = "סרבס" });
            man173.Models.Add(new VehicleModel() { Name = "קפטיבה" });
            mans.Add(man173);
            VehicleManufacturer man174 = new VehicleManufacturer() { Type = 3, Name = "אחר" };
            man174.Models = new List<VehicleModel>();
            man174.Models.Add(new VehicleModel() { Name = "כללי" });
            mans.Add(man174);
            VehicleManufacturer man175 = new VehicleManufacturer() { Type = 3, Name = "מחפש!" };
            man175.Models = new List<VehicleModel>();
            man175.Models.Add(new VehicleModel() { Name = "מחפש רכב שטח" });
            mans.Add(man175);
            VehicleManufacturer man176 = new VehicleManufacturer() { Type = 2, Name = "אופל" };
            man176.Models = new List<VehicleModel>();
            man176.Models.Add(new VehicleModel() { Name = "ויוארו" });
            man176.Models.Add(new VehicleModel() { Name = "קומבו" });
            mans.Add(man176);
            VehicleManufacturer man177 = new VehicleManufacturer() { Type = 2, Name = "איסוזו" };
            man177.Models = new List<VehicleModel>();
            man177.Models.Add(new VehicleModel() { Name = "2X4 D-MAX" });
            man177.Models.Add(new VehicleModel() { Name = "4X4 D-MAX" });
            man177.Models.Add(new VehicleModel() { Name = "איפון 2X4" });
            man177.Models.Add(new VehicleModel() { Name = "איפון 4X4" });
            man177.Models.Add(new VehicleModel() { Name = "טנדר" });
            mans.Add(man177);
            VehicleManufacturer man178 = new VehicleManufacturer() { Type = 2, Name = "ג'י.אם.סי / GMC" };
            man178.Models = new List<VehicleModel>();
            man178.Models.Add(new VehicleModel() { Name = "ונדורה" });
            man178.Models.Add(new VehicleModel() { Name = "טנדר 4X4" });
            man178.Models.Add(new VehicleModel() { Name = "סואנה" });
            man178.Models.Add(new VehicleModel() { Name = "סונומה" });
            man178.Models.Add(new VehicleModel() { Name = "סיירה 4X2" });
            man178.Models.Add(new VehicleModel() { Name = "סיירה 4X4" });
            man178.Models.Add(new VehicleModel() { Name = "ספארי" });
            man178.Models.Add(new VehicleModel() { Name = "ראלי" });
            mans.Add(man178);
            VehicleManufacturer man179 = new VehicleManufacturer() { Type = 2, Name = "גרייט וול" };
            man179.Models = new List<VehicleModel>();
            man179.Models.Add(new VehicleModel() { Name = "STEED" });
            mans.Add(man179);
            VehicleManufacturer man180 = new VehicleManufacturer() { Type = 2, Name = "דודג`" };
            man180.Models = new List<VehicleModel>();
            man180.Models.Add(new VehicleModel() { Name = "ראם" });
            mans.Add(man180);
            VehicleManufacturer man181 = new VehicleManufacturer() { Type = 2, Name = "טאטא" };
            man181.Models = new List<VehicleModel>();
            man181.Models.Add(new VehicleModel() { Name = "207" });
            man181.Models.Add(new VehicleModel() { Name = "טלקוליין 2X4" });
            man181.Models.Add(new VehicleModel() { Name = "טלקוליין 4X4" });
            mans.Add(man181);
            VehicleManufacturer man182 = new VehicleManufacturer() { Type = 2, Name = "טויוטה" };
            man182.Models = new List<VehicleModel>();
            man182.Models.Add(new VehicleModel() { Name = "הייאס" });
            man182.Models.Add(new VehicleModel() { Name = "היילקס 2X4" });
            man182.Models.Add(new VehicleModel() { Name = "היילקס 4X4" });
            man182.Models.Add(new VehicleModel() { Name = "היילקס ויגו 2X4" });
            man182.Models.Add(new VehicleModel() { Name = "היילקס ויגו 4X4" });
            man182.Models.Add(new VehicleModel() { Name = "פריוויה" });
            mans.Add(man182);
            VehicleManufacturer man183 = new VehicleManufacturer() { Type = 2, Name = "יונדאי" };
            man183.Models = new List<VehicleModel>();
            man183.Models.Add(new VehicleModel() { Name = "H1" });
            man183.Models.Add(new VehicleModel() { Name = "H100" });
            man183.Models.Add(new VehicleModel() { Name = "H100 TRUCK" });
            man183.Models.Add(new VehicleModel() { Name = "i800" });
            man183.Models.Add(new VehicleModel() { Name = "אנטרקולר" });
            mans.Add(man183);
            VehicleManufacturer man184 = new VehicleManufacturer() { Type = 2, Name = "לינקולן" };
            man184.Models = new List<VehicleModel>();
            man184.Models.Add(new VehicleModel() { Name = "MARK LT" });
            mans.Add(man184);
            VehicleManufacturer man185 = new VehicleManufacturer() { Type = 2, Name = "מאזדה" };
            man185.Models = new List<VehicleModel>();
            man185.Models.Add(new VehicleModel() { Name = "B2000" });
            man185.Models.Add(new VehicleModel() { Name = "B2500 2X4" });
            man185.Models.Add(new VehicleModel() { Name = "B2500 4X4" });
            man185.Models.Add(new VehicleModel() { Name = "BT50 2X4" });
            man185.Models.Add(new VehicleModel() { Name = "BT50 4X4" });
            man185.Models.Add(new VehicleModel() { Name = "E2000" });
            mans.Add(man185);
            VehicleManufacturer man186 = new VehicleManufacturer() { Type = 2, Name = "מיצובישי" };
            man186.Models = new List<VehicleModel>();
            man186.Models.Add(new VehicleModel() { Name = "L200 2X4" });
            man186.Models.Add(new VehicleModel() { Name = "L200 4X4" });
            man186.Models.Add(new VehicleModel() { Name = "L200 האנטר 2X4" });
            man186.Models.Add(new VehicleModel() { Name = "L200 האנטר 4X4" });
            man186.Models.Add(new VehicleModel() { Name = "L300" });
            man186.Models.Add(new VehicleModel() { Name = "L400" });
            man186.Models.Add(new VehicleModel() { Name = "בופאלו" });
            man186.Models.Add(new VehicleModel() { Name = "מאגנום 2X4" });
            man186.Models.Add(new VehicleModel() { Name = "מאגנום 4X4" });
            man186.Models.Add(new VehicleModel() { Name = "ספייס גיר L400" });
            man186.Models.Add(new VehicleModel() { Name = "קאנטר" });
            mans.Add(man186);
            VehicleManufacturer man187 = new VehicleManufacturer() { Type = 2, Name = "מרצדס" };
            man187.Models = new List<VehicleModel>();
            man187.Models.Add(new VehicleModel() { Name = "207" });
            man187.Models.Add(new VehicleModel() { Name = "208" });
            man187.Models.Add(new VehicleModel() { Name = "209" });
            man187.Models.Add(new VehicleModel() { Name = "210" });
            man187.Models.Add(new VehicleModel() { Name = "307" });
            man187.Models.Add(new VehicleModel() { Name = "309" });
            man187.Models.Add(new VehicleModel() { Name = "310" });
            man187.Models.Add(new VehicleModel() { Name = "312" });
            man187.Models.Add(new VehicleModel() { Name = "313" });
            man187.Models.Add(new VehicleModel() { Name = "315" });
            man187.Models.Add(new VehicleModel() { Name = "316" });
            man187.Models.Add(new VehicleModel() { Name = "319" });
            man187.Models.Add(new VehicleModel() { Name = "416" });
            man187.Models.Add(new VehicleModel() { Name = "ואריו" });
            man187.Models.Add(new VehicleModel() { Name = "ויאנו" });
            man187.Models.Add(new VehicleModel() { Name = "ויטו" });
            man187.Models.Add(new VehicleModel() { Name = "יונימוג" });
            man187.Models.Add(new VehicleModel() { Name = "ספרינטר" });
            mans.Add(man187);
            VehicleManufacturer man188 = new VehicleManufacturer() { Type = 2, Name = "ניסאן" };
            man188.Models = new List<VehicleModel>();
            man188.Models.Add(new VehicleModel() { Name = "NV200" });
            man188.Models.Add(new VehicleModel() { Name = "וואנט" });
            man188.Models.Add(new VehicleModel() { Name = "ווינר 2X4" });
            man188.Models.Add(new VehicleModel() { Name = "ווינר 4X4" });
            man188.Models.Add(new VehicleModel() { Name = "טנדר" });
            man188.Models.Add(new VehicleModel() { Name = "טרייד" });
            man188.Models.Add(new VehicleModel() { Name = "לארגו 2X4" });
            man188.Models.Add(new VehicleModel() { Name = "לארגו 4X4" });
            man188.Models.Add(new VehicleModel() { Name = "נבארה 2X4" });
            man188.Models.Add(new VehicleModel() { Name = "נבארה 4X4" });
            man188.Models.Add(new VehicleModel() { Name = "סרנה 2X4" });
            man188.Models.Add(new VehicleModel() { Name = "סרנה 4X4" });
            man188.Models.Add(new VehicleModel() { Name = "קבסטאר" });
            mans.Add(man188);
            VehicleManufacturer man189 = new VehicleManufacturer() { Type = 2, Name = "סאנגיונג" };
            man189.Models = new List<VehicleModel>();
            man189.Models.Add(new VehicleModel() { Name = "אקטיון ספורט" });
            man189.Models.Add(new VehicleModel() { Name = "מוסו 2X4" });
            man189.Models.Add(new VehicleModel() { Name = "מוסו 4X4" });
            man189.Models.Add(new VehicleModel() { Name = "רודיוס" });
            mans.Add(man189);
            VehicleManufacturer man190 = new VehicleManufacturer() { Type = 2, Name = "סובארו" };
            man190.Models = new List<VehicleModel>();
            man190.Models.Add(new VehicleModel() { Name = "E10" });
            man190.Models.Add(new VehicleModel() { Name = "E12" });
            man190.Models.Add(new VehicleModel() { Name = "טנדר 2X4" });
            man190.Models.Add(new VehicleModel() { Name = "טנדר 4X4" });
            mans.Add(man190);
            VehicleManufacturer man191 = new VehicleManufacturer() { Type = 2, Name = "סוזוקי" };
            man191.Models = new List<VehicleModel>();
            man191.Models.Add(new VehicleModel() { Name = "טנדר" });
            man191.Models.Add(new VehicleModel() { Name = "קארי" });
            mans.Add(man191);
            VehicleManufacturer man192 = new VehicleManufacturer() { Type = 2, Name = "סיאט" };
            man192.Models = new List<VehicleModel>();
            man192.Models.Add(new VehicleModel() { Name = "אינקה" });
            mans.Add(man192);
            VehicleManufacturer man193 = new VehicleManufacturer() { Type = 2, Name = "סיטרואן" };
            man193.Models = new List<VehicleModel>();
            man193.Models.Add(new VehicleModel() { Name = "C15" });
            man193.Models.Add(new VehicleModel() { Name = "C8" });
            man193.Models.Add(new VehicleModel() { Name = "ברלינגו (עד 2011)" });
            man193.Models.Add(new VehicleModel() { Name = "ברלינגו החדשה" });
            man193.Models.Add(new VehicleModel() { Name = "ג'אמפר" });
            man193.Models.Add(new VehicleModel() { Name = "ג'מפי" });
            man193.Models.Add(new VehicleModel() { Name = "נמו / Nemo" });
            mans.Add(man193);
            VehicleManufacturer man194 = new VehicleManufacturer() { Type = 2, Name = "סקודה" };
            man194.Models = new List<VehicleModel>();
            man194.Models.Add(new VehicleModel() { Name = "ואן" });
            man194.Models.Add(new VehicleModel() { Name = "טנדר" });
            man194.Models.Add(new VehicleModel() { Name = "פורמן" });
            mans.Add(man194);
            VehicleManufacturer man195 = new VehicleManufacturer() { Type = 2, Name = "פולקסווגן" };
            man195.Models = new List<VehicleModel>();
            man195.Models.Add(new VehicleModel() { Name = "LT" });
            man195.Models.Add(new VehicleModel() { Name = "LT 35" });
            man195.Models.Add(new VehicleModel() { Name = "אמארוק" });
            man195.Models.Add(new VehicleModel() { Name = "טרנספורטר" });
            man195.Models.Add(new VehicleModel() { Name = "טרנספורטר טנדר" });
            man195.Models.Add(new VehicleModel() { Name = "טרנספורטר מסחרי" });
            man195.Models.Add(new VehicleModel() { Name = "טרנספורטר נוסעים" });
            man195.Models.Add(new VehicleModel() { Name = "מולטיוואן" });
            man195.Models.Add(new VehicleModel() { Name = "קאדי" });
            man195.Models.Add(new VehicleModel() { Name = "קאדי לייף" });
            man195.Models.Add(new VehicleModel() { Name = "קאדי מקסי" });
            man195.Models.Add(new VehicleModel() { Name = "קראוול" });
            man195.Models.Add(new VehicleModel() { Name = "קראפטר" });
            man195.Models.Add(new VehicleModel() { Name = "שאטל" });
            mans.Add(man195);
            VehicleManufacturer man196 = new VehicleManufacturer() { Type = 2, Name = "פורד" };
            man196.Models = new List<VehicleModel>();
            man196.Models.Add(new VehicleModel() { Name = "F150" });
            man196.Models.Add(new VehicleModel() { Name = "F350" });
            man196.Models.Add(new VehicleModel() { Name = "אירוסטאר" });
            man196.Models.Add(new VehicleModel() { Name = "אקונוליין" });
            man196.Models.Add(new VehicleModel() { Name = "טורנאו קונקט" });
            man196.Models.Add(new VehicleModel() { Name = "טרנזיט" });
            man196.Models.Add(new VehicleModel() { Name = "קורייר" });
            man196.Models.Add(new VehicleModel() { Name = "ריינג'ר" });
            mans.Add(man196);
            VehicleManufacturer man197 = new VehicleManufacturer() { Type = 2, Name = "פיאג'ו" };
            man197.Models = new List<VehicleModel>();
            man197.Models.Add(new VehicleModel() { Name = "פורטר" });
            mans.Add(man197);
            VehicleManufacturer man198 = new VehicleManufacturer() { Type = 2, Name = "פיאט" };
            man198.Models = new List<VehicleModel>();
            man198.Models.Add(new VehicleModel() { Name = "אוליזה" });
            man198.Models.Add(new VehicleModel() { Name = "דובלו" });
            man198.Models.Add(new VehicleModel() { Name = "דוקאטו" });
            man198.Models.Add(new VehicleModel() { Name = "דוקאטו הרקולס" });
            man198.Models.Add(new VehicleModel() { Name = "סקודו" });
            man198.Models.Add(new VehicleModel() { Name = "פיורינו" });
            mans.Add(man198);
            VehicleManufacturer man199 = new VehicleManufacturer() { Type = 2, Name = "פיג'ו" };
            man199.Models = new List<VehicleModel>();
            man199.Models.Add(new VehicleModel() { Name = "J5" });
            man199.Models.Add(new VehicleModel() { Name = "J9" });
            man199.Models.Add(new VehicleModel() { Name = "אקספרט" });
            man199.Models.Add(new VehicleModel() { Name = "בוקסר" });
            man199.Models.Add(new VehicleModel() { Name = "ביפר" });
            man199.Models.Add(new VehicleModel() { Name = "טנדר" });
            man199.Models.Add(new VehicleModel() { Name = "פרטנר (עד 2011)" });
            man199.Models.Add(new VehicleModel() { Name = "פרטנר החדשה" });
            mans.Add(man199);
            VehicleManufacturer man200 = new VehicleManufacturer() { Type = 2, Name = "קיה" };
            man200.Models = new List<VehicleModel>();
            man200.Models.Add(new VehicleModel() { Name = "בסטה" });
            man200.Models.Add(new VehicleModel() { Name = "סופרטראק" });
            man200.Models.Add(new VehicleModel() { Name = "סרס" });
            man200.Models.Add(new VehicleModel() { Name = "פרג'יו" });
            mans.Add(man200);
            VehicleManufacturer man201 = new VehicleManufacturer() { Type = 2, Name = "רנו" };
            man201.Models = new List<VehicleModel>();
            man201.Models.Add(new VehicleModel() { Name = "אקספרס" });
            man201.Models.Add(new VehicleModel() { Name = "טראפיק" });
            man201.Models.Add(new VehicleModel() { Name = "מאסטר" });
            man201.Models.Add(new VehicleModel() { Name = "קנגו  החדשה" });
            man201.Models.Add(new VehicleModel() { Name = "קנגו (עד 2009)" });
            mans.Add(man201);
            VehicleManufacturer man202 = new VehicleManufacturer() { Type = 2, Name = "שברולט" };
            man202.Models = new List<VehicleModel>();
            man202.Models.Add(new VehicleModel() { Name = "SUT" });
            man202.Models.Add(new VehicleModel() { Name = "אסטרו" });
            man202.Models.Add(new VehicleModel() { Name = "טנדר" });
            man202.Models.Add(new VehicleModel() { Name = "נוואדה" });
            man202.Models.Add(new VehicleModel() { Name = "סוואנה" });
            man202.Models.Add(new VehicleModel() { Name = "סילברדו" });
            man202.Models.Add(new VehicleModel() { Name = "ספורט ואן" });
            man202.Models.Add(new VehicleModel() { Name = "קולורדו" });
            mans.Add(man202);
            VehicleManufacturer man203 = new VehicleManufacturer() { Type = 2, Name = "מחפש!" };
            man203.Models = new List<VehicleModel>();
            man203.Models.Add(new VehicleModel() { Name = "מחפש רכב" });
            mans.Add(man203);

            EFContext.Get().VehicleManufacturers.AddRange(mans);
        }

        private static string RandomPhoneHelper()
        {
            Random rnd = new Random();
            string[] areas = { "02", "03", "04", "08", "09", "072" };

            string result = areas[rnd.Next(areas.Length)];

            result += "-" + rnd.Next(3, 9);

            for (int i = 0; i < 6; i++)
            {
                result += rnd.Next(9);
            }

            return result;
        }

        private static string RandomCellPhoneHelper()
        {
            Random rnd = new Random();
            string[] areas = { "050", "052", "054", "058", "057"  };

            string result = areas[rnd.Next(areas.Length)];

            result += rnd.Next(2,9) + "-";

            for (int i = 0; i < 6; i++)
            {
                result += rnd.Next(9);
            }

            return result;
        }

        private static string RandomWordsHelper()
        {
            Random rnd = new Random();
            string alefBet = "אבגדהוזחטיכלמנסעפצקרשת";
            Dictionary<string, string> sofyot = new Dictionary<string, string>();
            sofyot.Add("מ","ם");
            sofyot.Add("נ","ן");
            sofyot.Add("צ","ץ");
            sofyot.Add("פ","ף");
            sofyot.Add("כ","ך");

            string result = "";

            int numOfWords = rnd.Next(4,10);
            for (int i = 0; i < numOfWords; i++)
            {
                int wordLength = rnd.Next(3,7);

                for (int j = 0; j < wordLength; j++)
			    {
			        result += alefBet[rnd.Next(alefBet.Length)];
			    }
                
                // if sofit change to sofit
                if (sofyot.Keys.Contains(result[result.Length - 1].ToString()))
                {
                    result = result.Substring(0,result.Length - 1) + sofyot[result[result.Length - 1].ToString()];
                }

                if (i < numOfWords - 1) result += " ";
            }

            return result;
        }

        private static void GeneratePrivateCars()
        {
            Random rnd = new Random();

            Region[] regions = EFContext.Get().Regions.ToArray();

            Category privateCarsCategory = EFContext.Get().Categories.FirstOrDefault(c => c.Name == "פרטי" && c.Parent != null && c.Parent.Name == "רכב" );

            int sellersCount = EFContext.Get().Sellers.Count();

            Seller seller = EFContext.Get().Sellers.OrderBy(s => s.Id).Skip(rnd.Next(sellersCount - 1)).Take(1).First();

            
            List<Car> cars = new List<Car>();

            for (int i = 0; i < 400; i++)
			{

                int vehManCount = EFContext.Get().VehicleManufacturers.Count();
                VehicleManufacturer man = EFContext.Get().VehicleManufacturers.OrderBy(s => s.Id).Skip(rnd.Next(vehManCount - 1)).Take(1).First();

                int modelsCount = man.Models.Count();
                VehicleModel model = man.Models.OrderBy(s => s.Id).Skip(rnd.Next(modelsCount - 1)).Take(1).First();

                cars.Add(
                    new Car()
                    {
                        CategoryId = privateCarsCategory.Id,
                        RegionId = regions[rnd.Next(regions.Length - 1)].Id,
                        Color = rnd.Next(10),
                        Created = DateTime.Now,
                        Desc = RandomWordsHelper(),
                        GearTypeId = rnd.Next(1,5),
                        EngineCapacity = 2000,
                        Kilometer = rnd.Next(10, 300) * 1000,
                        LastModified = DateTime.Now,
                        LastPopedUp = DateTime.Now,
                        LastTest = new DateTime(DateTime.Now.Year - 1, rnd.Next(1, 12), rnd.Next(1, 27)),
                        Title = RandomWordsHelper(),
                        Year = rnd.Next(1970, 2014),
                        OwnershipType = rnd.Next(1, 4),
                        OwnersCount = rnd.Next(1, 4),
                        Price = rnd.Next(5, 150) * 1000,
                        Type = 1,
                        SellerId = seller.Id,
                        ManufacturerId = man.Id,
                        ModelId = model.Id,
                        Phone1 = RandomCellPhoneHelper(),
                        Phone2 = RandomPhoneHelper(),
                    });
			}
                    
            EFContext.Get().Cars.AddRange(cars);
        }
        private static void GeneratePrivateJeeps()
        {
            Random rnd = new Random();

            Region[] regions = EFContext.Get().Regions.ToArray();

            Category JeepsCategory = EFContext.Get().Categories.FirstOrDefault(c => c.Name == "פרטי" && c.Parent != null && c.Parent.Name == "רכב");

            int sellersCount = EFContext.Get().Sellers.Count();

            Seller seller = EFContext.Get().Sellers.OrderBy(s => s.Id).Skip(rnd.Next(sellersCount - 1)).Take(1).First();


            List<Jeep> Jeeps = new List<Jeep>();

            for (int i = 0; i < 400; i++)
            {

                int vehManCount = EFContext.Get().VehicleManufacturers.Count();
                VehicleManufacturer man = EFContext.Get().VehicleManufacturers.OrderBy(s => s.Id).Skip(rnd.Next(vehManCount - 1)).Take(1).First();

                int modelsCount = man.Models.Count();
                VehicleModel model = man.Models.OrderBy(s => s.Id).Skip(rnd.Next(modelsCount - 1)).Take(1).First();

                Jeeps.Add(
                    new Jeep()
                    {
                        CategoryId = JeepsCategory.Id,
                        RegionId = regions[rnd.Next(regions.Length - 1)].Id,
                        Color = rnd.Next(10),
                        Created = DateTime.Now,
                        Desc = RandomWordsHelper(),
                        GearTypeId = rnd.Next(1, 5),
                        EngineCapacity = 2000,
                        Kilometer = rnd.Next(10, 300) * 1000,
                        LastModified = DateTime.Now,
                        LastPopedUp = DateTime.Now,
                        LastTest = new DateTime(DateTime.Now.Year - 1, rnd.Next(1, 12), rnd.Next(1, 27)),
                        Title = RandomWordsHelper(),
                        Year = rnd.Next(1970, 2014),
                        OwnershipType = rnd.Next(1, 4),
                        OwnersCount = rnd.Next(1, 4),
                        Price = rnd.Next(5, 150) * 1000,
                        Type = 2,
                        SellerId = seller.Id,
                        ManufacturerId = man.Id,
                        ModelId = model.Id,
                        Phone1 = RandomCellPhoneHelper(),
                        Phone2 = RandomPhoneHelper(),
                    });
            }
            EFContext.Get().Jeeps.AddRange(Jeeps);
        }

        //Commercial

        private static void GenerateCommercial()
        {
            Random rnd = new Random();

            Region[] regions = EFContext.Get().Regions.ToArray();

            Category CommercialsCategory = EFContext.Get().Categories.FirstOrDefault(c => c.Name == "פרטי" && c.Parent != null && c.Parent.Name == "רכב");

            int sellersCount = EFContext.Get().Sellers.Count();

            Seller seller = EFContext.Get().Sellers.OrderBy(s => s.Id).Skip(rnd.Next(sellersCount - 1)).Take(1).First();


            List<Commercial> Commercials = new List<Commercial>();

            for (int i = 0; i < 400; i++)
            {

                int vehManCount = EFContext.Get().VehicleManufacturers.Count();
                VehicleManufacturer man = EFContext.Get().VehicleManufacturers.OrderBy(s => s.Id).Skip(rnd.Next(vehManCount - 1)).Take(1).First();

                int modelsCount = man.Models.Count();
                VehicleModel model = man.Models.OrderBy(s => s.Id).Skip(rnd.Next(modelsCount - 1)).Take(1).First();

                Commercials.Add(
                    new Commercial()
                    {
                        CategoryId = CommercialsCategory.Id,
                        RegionId = regions[rnd.Next(regions.Length - 1)].Id,
                        Color = rnd.Next(10),
                        Created = DateTime.Now,
                        Desc = RandomWordsHelper(),
                        GearTypeId = rnd.Next(1, 5),
                        EngineCapacity = 2000,
                        Kilometer = rnd.Next(10, 300) * 1000,
                        LastModified = DateTime.Now,
                        LastPopedUp = DateTime.Now,
                        LastTest = new DateTime(DateTime.Now.Year - 1, rnd.Next(1, 12), rnd.Next(1, 27)),
                        Title = RandomWordsHelper(),
                        Year = rnd.Next(1970, 2014),
                        OwnershipType = rnd.Next(1, 4),
                        OwnersCount = rnd.Next(1, 4),
                        Price = rnd.Next(5, 150) * 1000,
                        Type = 2,
                        SellerId = seller.Id,
                        ManufacturerId = man.Id,
                        ModelId = model.Id,
                        Phone1 = RandomCellPhoneHelper(),
                        Phone2 = RandomPhoneHelper(),
                    });
            }
            EFContext.Get().Commercials.AddRange(Commercials);
        }

        private static void GeneratePrivateScooter()
            {
            Random rnd = new Random();

            Region[] regions = EFContext.Get().Regions.ToArray();

            Category privateCarsCategory = EFContext.Get().Categories.FirstOrDefault(c => c.Name == "פרטי" && c.Parent != null && c.Parent.Name == "רכב" );

            int sellersCount = EFContext.Get().Sellers.Count();

            Seller seller = EFContext.Get().Sellers.OrderBy(s => s.Id).Skip(rnd.Next(sellersCount - 1)).Take(1).First();

            
            List<Scooter> Scooters = new List<Scooter>();

            for (int i = 0; i < 400; i++)
			{

                int vehManCount = EFContext.Get().VehicleManufacturers.Count();
                VehicleManufacturer man = EFContext.Get().VehicleManufacturers.OrderBy(s => s.Id).Skip(rnd.Next(vehManCount - 1)).Take(1).First();

                int modelsCount = man.Models.Count();
                VehicleModel model = man.Models.OrderBy(s => s.Id).Skip(rnd.Next(modelsCount - 1)).Take(1).First();

                Scooters.Add(
                    new Scooter()
                    {
                        CategoryId = privateCarsCategory.Id,
                        RegionId = regions[rnd.Next(regions.Length - 1)].Id,
                        Color = rnd.Next(10),
                        Created = DateTime.Now,
                        Desc = RandomWordsHelper(),
                       // GearTypeId = rnd.Next(1,5),
                        EngineCapacity = 2000,
                        Kilometer = rnd.Next(10, 300) * 1000,
                        LastModified = DateTime.Now,
                        LastPopedUp = DateTime.Now,
                        LastTest = new DateTime(DateTime.Now.Year - 1, rnd.Next(1, 12), rnd.Next(1, 27)),
                        Title = RandomWordsHelper(),
                        Year = rnd.Next(1970, 2014),
                        OwnershipType = rnd.Next(1, 4),
                        OwnersCount = rnd.Next(1, 4),
                        Price = rnd.Next(5, 150) * 1000,
                        Type = 5,
                        SellerId = seller.Id,
                        ManufacturerId = man.Id,
                        ModelId = model.Id,
                        Phone1 = RandomCellPhoneHelper(),
                        Phone2 = RandomPhoneHelper(),
                    });
			}

            EFContext.Get().Scooter.AddRange(Scooters);
        }
        // אופניים

        private static void GenerateMotorcycles()
        {
            Random rnd = new Random();

            Region[] regions = EFContext.Get().Regions.ToArray();

            Category privateCarsCategory = EFContext.Get().Categories.FirstOrDefault(c => c.Name == "פרטי" && c.Parent != null && c.Parent.Name == "רכב" );

            int sellersCount = EFContext.Get().Sellers.Count();

            Seller seller = EFContext.Get().Sellers.OrderBy(s => s.Id).Skip(rnd.Next(sellersCount - 1)).Take(1).First();


            List<Motorcycle> Motorcycles = new List<Motorcycle>();

            for (int i = 0; i < 400; i++)
			{

                int vehManCount = EFContext.Get().VehicleManufacturers.Count();
                VehicleManufacturer man = EFContext.Get().VehicleManufacturers.OrderBy(s => s.Id).Skip(rnd.Next(vehManCount - 1)).Take(1).First();

                int modelsCount = man.Models.Count();
                VehicleModel model = man.Models.OrderBy(s => s.Id).Skip(rnd.Next(modelsCount - 1)).Take(1).First();

                Motorcycles.Add(
                    new Motorcycle()
                    {
                        CategoryId = privateCarsCategory.Id,
                        RegionId = regions[rnd.Next(regions.Length - 1)].Id,
                        Color = rnd.Next(10),
                        Created = DateTime.Now,
                        Desc = RandomWordsHelper(),
                       // GearTypeId = rnd.Next(1,5),
                        EngineCapacity = 2000,
                        Kilometer = rnd.Next(10, 300) * 1000,
                        LastModified = DateTime.Now,
                        LastPopedUp = DateTime.Now,
                        LastTest = new DateTime(DateTime.Now.Year - 1, rnd.Next(1, 12), rnd.Next(1, 27)),
                        Title = RandomWordsHelper(),
                        Year = rnd.Next(1970, 2014),
                        OwnershipType = rnd.Next(1, 4),
                        OwnersCount = rnd.Next(1, 4),
                        Price = rnd.Next(5, 150) * 1000,
                        Type = 4,
                        SellerId = seller.Id,
                        ManufacturerId = man.Id,
                        ModelId = model.Id,
                        Phone1 = RandomCellPhoneHelper(),
                        Phone2 = RandomPhoneHelper(),
                    });
			}

            EFContext.Get().Motorcycles.AddRange(Motorcycles);
                  

                }
                

        private static void GenerateCarsGearTypes()
        {
            var gearTypes = new CarGearType[] { new CarGearType() { Name = "אוטומט" }, 
                            new CarGearType() { Name =  "ידני" },
                            new CarGearType() { Name =  "טיפ-טרוניק" },
                            new CarGearType() { Name = "רובוטי" },
                            new CarGearType() { Name = "DSG" }
            };

            EFContext.Get().CarsGearTypes.AddRange(gearTypes);
        }

        // EFContext.Get().VehicleManufacturers.AddRange(mans);
        private static void GenerateColors()
        {
            var Colors = new Color[] { new Color() { Name = "אדום" }, 
                            new Color() { Name =  "אדום מטאלי" },
                            new Color() { Name =  "אפור" },
                            new Color() { Name = "אפור מטאלי" },
                            new Color() { Name = "אפור עכבר" },
                            new Color() { Name = "בורדו" },
                            new Color() { Name = "בורדו מטאלי" },
                            new Color() { Name = "בז" },
                            new Color() { Name = "בז מטאלי" },
                            new Color() { Name = "ברונזה" },
                            new Color() { Name = "ברונזה מטאלי" },
                            new Color() { Name = "ורוד" },
                            new Color() { Name = "זהב" },
                            new Color() { Name = "זהב מטאלי" },
                            new Color() { Name = "חום" },
                            new Color() { Name = "חום מטאלי" },
                            new Color() { Name = "חרדל" },
                            new Color() { Name = "טורקיז" },
                            new Color() { Name = "ירוק" },
                            new Color() { Name = "ירוק בהיר" },
                            new Color() { Name =  "ירוק בקבוק" },
                            new Color() { Name =  "ירוק מטאלי" },
                            new Color() { Name = "כחול" },
                            new Color() { Name = "כחול מטאלי" },
                            new Color() { Name = "כחול בהיר" },
                            new Color() { Name = "בהיר מטאלי" },
                            new Color() { Name = "כחול כהה" },
                            new Color() { Name = "כחול בהיר" },
                            new Color() { Name = "כחול בהיר מטאלי" },
                            new Color() { Name = "כחול כהה" },
                            new Color() { Name = "כחול כהה מטאלי" },
                            new Color() { Name = "כסוף" },
                            new Color() { Name = "כסוף מטאלי" },
                            new Color() { Name = "חום" },
                            new Color() { Name = "כתום" },
                            new Color() { Name = "לבן" },
                            new Color() { Name = "לבן מטאלי" },
                            new Color() { Name = "לבן פנינה" },
                            new Color() { Name = "לבן שנהב" },
                            new Color() { Name = "סגול" },
                            new Color() { Name = "סגול חציל" },
                            new Color() { Name = "סגול מטאלי" },
                            new Color() { Name = "צהוב" },
                            new Color() { Name = "צהוב מטאלי" },
                            new Color() { Name = "שמפניה" },
                            new Color() { Name = "תכלת" },
                            new Color() { Name = "תכלת מטאלי" },
                            new Color() { Name = "שחור" },
                            new Color() { Name = "כסף מטלי" }
            };

            EFContext.Get().Colors.AddRange(Colors);
        }

    }
}