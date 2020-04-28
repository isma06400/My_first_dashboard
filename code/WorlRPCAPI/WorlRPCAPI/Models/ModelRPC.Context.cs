﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WorlRPCAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class WorldRPCEntities : DbContext
    {
        public WorldRPCEntities()
            : base("name=WorldRPCEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<getDataFromConsume_Result> getDataFromConsume(Nullable<int> yearFrom, Nullable<int> yearTo)
        {
            var yearFromParameter = yearFrom.HasValue ?
                new ObjectParameter("YearFrom", yearFrom) :
                new ObjectParameter("YearFrom", typeof(int));
    
            var yearToParameter = yearTo.HasValue ?
                new ObjectParameter("YearTo", yearTo) :
                new ObjectParameter("YearTo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getDataFromConsume_Result>("getDataFromConsume", yearFromParameter, yearToParameter);
        }
    
        public virtual ObjectResult<getDataFromConsumeCountry_Result> getDataFromConsumeCountry(Nullable<int> yearFrom, Nullable<int> yearTo, string country)
        {
            var yearFromParameter = yearFrom.HasValue ?
                new ObjectParameter("YearFrom", yearFrom) :
                new ObjectParameter("YearFrom", typeof(int));
    
            var yearToParameter = yearTo.HasValue ?
                new ObjectParameter("YearTo", yearTo) :
                new ObjectParameter("YearTo", typeof(int));
    
            var countryParameter = country != null ?
                new ObjectParameter("Country", country) :
                new ObjectParameter("Country", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getDataFromConsumeCountry_Result>("getDataFromConsumeCountry", yearFromParameter, yearToParameter, countryParameter);
        }
    
        public virtual ObjectResult<getDataFromConsumeRegion_Result> getDataFromConsumeRegion(Nullable<int> yearFrom, Nullable<int> yearTo, string region)
        {
            var yearFromParameter = yearFrom.HasValue ?
                new ObjectParameter("YearFrom", yearFrom) :
                new ObjectParameter("YearFrom", typeof(int));
    
            var yearToParameter = yearTo.HasValue ?
                new ObjectParameter("YearTo", yearTo) :
                new ObjectParameter("YearTo", typeof(int));
    
            var regionParameter = region != null ?
                new ObjectParameter("Region", region) :
                new ObjectParameter("Region", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getDataFromConsumeRegion_Result>("getDataFromConsumeRegion", yearFromParameter, yearToParameter, regionParameter);
        }
    
        public virtual ObjectResult<getDataFromProduction_Result> getDataFromProduction(Nullable<int> yearFrom, Nullable<int> yearTo)
        {
            var yearFromParameter = yearFrom.HasValue ?
                new ObjectParameter("YearFrom", yearFrom) :
                new ObjectParameter("YearFrom", typeof(int));
    
            var yearToParameter = yearTo.HasValue ?
                new ObjectParameter("YearTo", yearTo) :
                new ObjectParameter("YearTo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getDataFromProduction_Result>("getDataFromProduction", yearFromParameter, yearToParameter);
        }
    
        public virtual ObjectResult<getDataFromProductionCountry_Result> getDataFromProductionCountry(Nullable<int> yearFrom, Nullable<int> yearTo, string country)
        {
            var yearFromParameter = yearFrom.HasValue ?
                new ObjectParameter("YearFrom", yearFrom) :
                new ObjectParameter("YearFrom", typeof(int));
    
            var yearToParameter = yearTo.HasValue ?
                new ObjectParameter("YearTo", yearTo) :
                new ObjectParameter("YearTo", typeof(int));
    
            var countryParameter = country != null ?
                new ObjectParameter("Country", country) :
                new ObjectParameter("Country", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getDataFromProductionCountry_Result>("getDataFromProductionCountry", yearFromParameter, yearToParameter, countryParameter);
        }
    
        public virtual ObjectResult<getDataFromProductionRegion_Result> getDataFromProductionRegion(Nullable<int> yearFrom, Nullable<int> yearTo, string region)
        {
            var yearFromParameter = yearFrom.HasValue ?
                new ObjectParameter("YearFrom", yearFrom) :
                new ObjectParameter("YearFrom", typeof(int));
    
            var yearToParameter = yearTo.HasValue ?
                new ObjectParameter("YearTo", yearTo) :
                new ObjectParameter("YearTo", typeof(int));
    
            var regionParameter = region != null ?
                new ObjectParameter("Region", region) :
                new ObjectParameter("Region", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getDataFromProductionRegion_Result>("getDataFromProductionRegion", yearFromParameter, yearToParameter, regionParameter);
        }
    
        public virtual ObjectResult<getDataFromReserves_Result> getDataFromReserves(Nullable<int> yearFrom, Nullable<int> yearTo)
        {
            var yearFromParameter = yearFrom.HasValue ?
                new ObjectParameter("YearFrom", yearFrom) :
                new ObjectParameter("YearFrom", typeof(int));
    
            var yearToParameter = yearTo.HasValue ?
                new ObjectParameter("YearTo", yearTo) :
                new ObjectParameter("YearTo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getDataFromReserves_Result>("getDataFromReserves", yearFromParameter, yearToParameter);
        }
    
        public virtual ObjectResult<getDataFromReservesCountry_Result> getDataFromReservesCountry(Nullable<int> yearFrom, Nullable<int> yearTo, string country)
        {
            var yearFromParameter = yearFrom.HasValue ?
                new ObjectParameter("YearFrom", yearFrom) :
                new ObjectParameter("YearFrom", typeof(int));
    
            var yearToParameter = yearTo.HasValue ?
                new ObjectParameter("YearTo", yearTo) :
                new ObjectParameter("YearTo", typeof(int));
    
            var countryParameter = country != null ?
                new ObjectParameter("Country", country) :
                new ObjectParameter("Country", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getDataFromReservesCountry_Result>("getDataFromReservesCountry", yearFromParameter, yearToParameter, countryParameter);
        }
    
        public virtual ObjectResult<getDataFromReservesRegion_Result> getDataFromReservesRegion(Nullable<int> yearFrom, Nullable<int> yearTo, string region)
        {
            var yearFromParameter = yearFrom.HasValue ?
                new ObjectParameter("YearFrom", yearFrom) :
                new ObjectParameter("YearFrom", typeof(int));
    
            var yearToParameter = yearTo.HasValue ?
                new ObjectParameter("YearTo", yearTo) :
                new ObjectParameter("YearTo", typeof(int));
    
            var regionParameter = region != null ?
                new ObjectParameter("Region", region) :
                new ObjectParameter("Region", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getDataFromReservesRegion_Result>("getDataFromReservesRegion", yearFromParameter, yearToParameter, regionParameter);
        }
    }
}
