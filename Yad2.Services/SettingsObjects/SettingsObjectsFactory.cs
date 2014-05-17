using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.EFRepositories;
using Yad2.Services.Interfaces;



namespace Yad2.Services.SettingsObjects
{
    public class SettingsObjectsFactory
    {
        public static ISettingsObj<T> Create<T>()
        {

            ISettingsObj<T> result = null;

            string typeName = typeof(T).ToString();
            if (typeName.Contains("."))
            {
                int lastIndexOfDot = typeName.LastIndexOf(".");
                typeName = typeName.Substring(lastIndexOfDot + 1, typeName.Length - lastIndexOfDot - 1);
            }

            switch (typeName)
            {
                case "Car":
                    result = new CarSettingsObject()
                    {
                        Regions = EFContext.Get().Regions.Select(c => new ListItem() { Id = c.Id, Name = c.Name, PId = c.ParentId }).ToList(),
                        Manufacturers = EFContext.Get().VehicleManufacturers.Where(c => c.Type == 1).Select(c => new ListItem() { Id = c.Id, Name = c.Name }).ToList(),
                        Models = EFContext.Get().VehicleModels.Where(c => c.Manufacturer.Type == 1).Select(c => new ListItem() { Id = c.Id, Name = c.Name, PId = c.Manufacturer.Id }).ToList(),
                        CarGearType = EFContext.Get().CarsGearTypes.Select(c => new ListItem() { Id = c.Id, Name = c.Name }).ToList(),
                        Citeis = EFContext.Get().Cities.Select(c => new ListItem() { Id = c.Id, Name = c.Name, PId = c.RegionId }),
                        Colors = EFContext.Get().Colors.Select(c => new ListItem() { Id = c.Id, Name = c.Name }).ToList()
                    } as ISettingsObj<T>;

                    break;

                case "Motorcycle":
                    result = new MotorcycleSittingObjects()
                    {
                        Regions = EFContext.Get().Regions.Select(c => new ListItem() { Id = c.Id, Name = c.Name, PId = c.ParentId }).ToList(),
                        Manufacturers = EFContext.Get().VehicleManufacturers.Where(c => c.Type == 4).Select(c => new ListItem() { Id = c.Id, Name = c.Name }).ToList(),
                        Models = EFContext.Get().VehicleModels.Where(c => c.Manufacturer.Type == 4).Select(c => new ListItem() { Id = c.Id, Name = c.Name, PId = c.Manufacturer.Id }).ToList(),
                        //CarGearType = EFContext.Get().CarsGearTypes.Select(c => new ListItem() { Id = c.Id, Name = c.Name }).ToList(),
                        Citeis = EFContext.Get().Cities.Select(c => new ListItem() { Id = c.Id, Name = c.Name, PId = c.RegionId })
                    } as ISettingsObj<T>;

                    break;


                case "Trucks":

                    result = new TrucksSittingObject()
                    {
                        Regions = EFContext.Get().Regions.Select(c => new ListItem() { Id = c.Id, Name = c.Name, PId = c.ParentId }).ToList(),
                        Manufacturers = EFContext.Get().VehicleManufacturers.Where(c => c.Type == 1).Select(c => new ListItem() { Id = c.Id, Name = c.Name }).ToList(),
                        Models = EFContext.Get().VehicleModels.Where(c => c.Manufacturer.Type == 1).Select(c => new ListItem() { Id = c.Id, Name = c.Name, PId = c.Manufacturer.Id }).ToList(),
                        //CarGearType = EFContext.Get().CarsGearTypes.Select(c => new ListItem() { Id = c.Id, Name = c.Name }).ToList(),
                        Citeis = EFContext.Get().Cities.Select(c => new ListItem() { Id = c.Id, Name = c.Name, PId = c.RegionId })
                    } as ISettingsObj<T>;

                    break;

                case "Scooter":

                    result = new ScoterSittingObject()
                    {
                        Regions = EFContext.Get().Regions.Select(c => new ListItem() { Id = c.Id, Name = c.Name, PId = c.ParentId }).ToList(),
                        Manufacturers = EFContext.Get().VehicleManufacturers.Where(c => c.Type == 5).Select(c => new ListItem() { Id = c.Id, Name = c.Name }).ToList(),
                        Models = EFContext.Get().VehicleModels.Where(c => c.Manufacturer.Type == 5).Select(c => new ListItem() { Id = c.Id, Name = c.Name, PId = c.Manufacturer.Id }).ToList(),
                        //CarGearType = EFContext.Get().CarsGearTypes.Select(c => new ListItem() { Id = c.Id, Name = c.Name }).ToList(),
                        Citeis = EFContext.Get().Cities.Select(c => new ListItem() { Id = c.Id, Name = c.Name, PId = c.RegionId })
                    } as ISettingsObj<T>;

                    break;

                case "Jeep":

                    result = new JeepSitttingObject()
                    {
                        Regions = EFContext.Get().Regions.Select(c => new ListItem() { Id = c.Id, Name = c.Name, PId = c.ParentId }).ToList(),
                        Manufacturers = EFContext.Get().VehicleManufacturers.Where(c => c.Type == 3).Select(c => new ListItem() { Id = c.Id, Name = c.Name }).ToList(),
                        Models = EFContext.Get().VehicleModels.Where(c => c.Manufacturer.Type == 3).Select(c => new ListItem() { Id = c.Id, Name = c.Name, PId = c.Manufacturer.Id }).ToList(),
                        //CarGearType = EFContext.Get().CarsGearTypes.Select(c => new ListItem() { Id = c.Id, Name = c.Name }).ToList(),
                        Citeis = EFContext.Get().Cities.Select(c => new ListItem() { Id = c.Id, Name = c.Name, PId = c.RegionId })
                    } as ISettingsObj<T>;

                    break;


                case "Commercial":

                    result = new CommercialSittingObjecr()
                    {
                        Regions = EFContext.Get().Regions.Select(c => new ListItem() { Id = c.Id, Name = c.Name, PId = c.ParentId }).ToList(),
                        Manufacturers = EFContext.Get().VehicleManufacturers.Where(c => c.Type == 2).Select(c => new ListItem() { Id = c.Id, Name = c.Name }).ToList(),
                        Models = EFContext.Get().VehicleModels.Where(c => c.Manufacturer.Type == 2).Select(c => new ListItem() { Id = c.Id, Name = c.Name, PId = c.Manufacturer.Id }).ToList(),
                        //CarGearType = EFContext.Get().CarsGearTypes.Select(c => new ListItem() { Id = c.Id, Name = c.Name }).ToList(),
                        Citeis = EFContext.Get().Cities.Select(c => new ListItem() { Id = c.Id, Name = c.Name, PId = c.RegionId })
                    } as ISettingsObj<T>;

                    break;

                case "SecondHand":
                    result = new SecondhandSettingsObject()
                    {
                        Regions = EFContext.Get().Regions.Select(c => new ListItem() { Id = c.Id, Name = c.Name, PId = c.ParentId }).ToList(),
                        Categories = EFContext.Get().SecondHandTypes.Where(c => c.ParentTypeId == null).Select(c => new ListItem() { Id = c.Id, Name = c.Name }).ToList(),
                        SubCategories = EFContext.Get().SecondHandTypes.Where(c => c.ParentTypeId != null).Select(c => new ListItem() { Id = c.Id, Name = c.Name, PId = c.ParentTypeId }).ToList(),
                        States = EFContext.Get().SecondHandStates.Select(c => new ListItem() { Id = c.Id, Name = c.Name }).ToList()
                    } as ISettingsObj<T>;

                    break;
            }

            return result;
        }
    }

}