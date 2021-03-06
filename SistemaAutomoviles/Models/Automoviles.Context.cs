﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaAutomoviles.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class MyDbContext1 : DbContext
    {
        public MyDbContext1()
            : base("name=MyDbContext1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Automovil> Automovil { get; set; }
        public virtual DbSet<Solicitud_de_transporte> Solicitud_de_transporte { get; set; }
        public virtual DbSet<transporte_auto> transporte_auto { get; set; }
    
        public virtual int AgregaAuto(string folio, string marca, string modelo, string color, string tipo_transmision, string descripcion)
        {
            var folioParameter = folio != null ?
                new ObjectParameter("folio", folio) :
                new ObjectParameter("folio", typeof(string));
    
            var marcaParameter = marca != null ?
                new ObjectParameter("marca", marca) :
                new ObjectParameter("marca", typeof(string));
    
            var modeloParameter = modelo != null ?
                new ObjectParameter("modelo", modelo) :
                new ObjectParameter("modelo", typeof(string));
    
            var colorParameter = color != null ?
                new ObjectParameter("color", color) :
                new ObjectParameter("color", typeof(string));
    
            var tipo_transmisionParameter = tipo_transmision != null ?
                new ObjectParameter("Tipo_transmision", tipo_transmision) :
                new ObjectParameter("Tipo_transmision", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AgregaAuto", folioParameter, marcaParameter, modeloParameter, colorParameter, tipo_transmisionParameter, descripcionParameter);
        }
    
        public virtual int ModificaAuto(string folio, string marca, string modelo, string color, string tipo_transmision, string descripcion)
        {
            var folioParameter = folio != null ?
                new ObjectParameter("folio", folio) :
                new ObjectParameter("folio", typeof(string));
    
            var marcaParameter = marca != null ?
                new ObjectParameter("marca", marca) :
                new ObjectParameter("marca", typeof(string));
    
            var modeloParameter = modelo != null ?
                new ObjectParameter("modelo", modelo) :
                new ObjectParameter("modelo", typeof(string));
    
            var colorParameter = color != null ?
                new ObjectParameter("color", color) :
                new ObjectParameter("color", typeof(string));
    
            var tipo_transmisionParameter = tipo_transmision != null ?
                new ObjectParameter("Tipo_transmision", tipo_transmision) :
                new ObjectParameter("Tipo_transmision", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ModificaAuto", folioParameter, marcaParameter, modeloParameter, colorParameter, tipo_transmisionParameter, descripcionParameter);
        }
    
        public virtual ObjectResult<VerAutos_Result> VerAutos()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<VerAutos_Result>("VerAutos");
        }
    
        public virtual ObjectResult<VerAutoTransporte_Result> VerAutoTransporte()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<VerAutoTransporte_Result>("VerAutoTransporte");
        }
    
        public virtual int PeticionAutoTransporte(Nullable<int> lote, string folio, string marca, string modelo, string color, string tipo_transmision, string descripcion)
        {
            var loteParameter = lote.HasValue ?
                new ObjectParameter("lote", lote) :
                new ObjectParameter("lote", typeof(int));
    
            var folioParameter = folio != null ?
                new ObjectParameter("folio", folio) :
                new ObjectParameter("folio", typeof(string));
    
            var marcaParameter = marca != null ?
                new ObjectParameter("marca", marca) :
                new ObjectParameter("marca", typeof(string));
    
            var modeloParameter = modelo != null ?
                new ObjectParameter("modelo", modelo) :
                new ObjectParameter("modelo", typeof(string));
    
            var colorParameter = color != null ?
                new ObjectParameter("color", color) :
                new ObjectParameter("color", typeof(string));
    
            var tipo_transmisionParameter = tipo_transmision != null ?
                new ObjectParameter("Tipo_transmision", tipo_transmision) :
                new ObjectParameter("Tipo_transmision", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PeticionAutoTransporte", loteParameter, folioParameter, marcaParameter, modeloParameter, colorParameter, tipo_transmisionParameter, descripcionParameter);
        }
    
        public virtual ObjectResult<transporte_auto> FN_PeticionAutoTransporte1(Nullable<int> lote, string folio, string marca, string modelo, string color, string tipo_transmision, string descripcion)
        {
            var loteParameter = lote.HasValue ?
                new ObjectParameter("lote", lote) :
                new ObjectParameter("lote", typeof(int));
    
            var folioParameter = folio != null ?
                new ObjectParameter("folio", folio) :
                new ObjectParameter("folio", typeof(string));
    
            var marcaParameter = marca != null ?
                new ObjectParameter("marca", marca) :
                new ObjectParameter("marca", typeof(string));
    
            var modeloParameter = modelo != null ?
                new ObjectParameter("modelo", modelo) :
                new ObjectParameter("modelo", typeof(string));
    
            var colorParameter = color != null ?
                new ObjectParameter("color", color) :
                new ObjectParameter("color", typeof(string));
    
            var tipo_transmisionParameter = tipo_transmision != null ?
                new ObjectParameter("Tipo_transmision", tipo_transmision) :
                new ObjectParameter("Tipo_transmision", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<transporte_auto>("FN_PeticionAutoTransporte1", loteParameter, folioParameter, marcaParameter, modeloParameter, colorParameter, tipo_transmisionParameter, descripcionParameter);
        }
    
        public virtual ObjectResult<transporte_auto> FN_PeticionAutoTransporte1(Nullable<int> lote, string folio, string marca, string modelo, string color, string tipo_transmision, string descripcion, MergeOption mergeOption)
        {
            var loteParameter = lote.HasValue ?
                new ObjectParameter("lote", lote) :
                new ObjectParameter("lote", typeof(int));
    
            var folioParameter = folio != null ?
                new ObjectParameter("folio", folio) :
                new ObjectParameter("folio", typeof(string));
    
            var marcaParameter = marca != null ?
                new ObjectParameter("marca", marca) :
                new ObjectParameter("marca", typeof(string));
    
            var modeloParameter = modelo != null ?
                new ObjectParameter("modelo", modelo) :
                new ObjectParameter("modelo", typeof(string));
    
            var colorParameter = color != null ?
                new ObjectParameter("color", color) :
                new ObjectParameter("color", typeof(string));
    
            var tipo_transmisionParameter = tipo_transmision != null ?
                new ObjectParameter("Tipo_transmision", tipo_transmision) :
                new ObjectParameter("Tipo_transmision", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<transporte_auto>("FN_PeticionAutoTransporte1", mergeOption, loteParameter, folioParameter, marcaParameter, modeloParameter, colorParameter, tipo_transmisionParameter, descripcionParameter);
        }
    
        public virtual int fn_peticiontransporte(Nullable<int> lote, string folio, string marca, string modelo, string color, string tipo_transmision, string descripcion)
        {
            var loteParameter = lote.HasValue ?
                new ObjectParameter("lote", lote) :
                new ObjectParameter("lote", typeof(int));
    
            var folioParameter = folio != null ?
                new ObjectParameter("folio", folio) :
                new ObjectParameter("folio", typeof(string));
    
            var marcaParameter = marca != null ?
                new ObjectParameter("marca", marca) :
                new ObjectParameter("marca", typeof(string));
    
            var modeloParameter = modelo != null ?
                new ObjectParameter("modelo", modelo) :
                new ObjectParameter("modelo", typeof(string));
    
            var colorParameter = color != null ?
                new ObjectParameter("color", color) :
                new ObjectParameter("color", typeof(string));
    
            var tipo_transmisionParameter = tipo_transmision != null ?
                new ObjectParameter("Tipo_transmision", tipo_transmision) :
                new ObjectParameter("Tipo_transmision", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("fn_peticiontransporte", loteParameter, folioParameter, marcaParameter, modeloParameter, colorParameter, tipo_transmisionParameter, descripcionParameter);
        }
    }
}
