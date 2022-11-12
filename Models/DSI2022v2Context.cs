using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace PPAI_Grupo5_v2.Models
{
    public partial class DSI2022v2Context : DbContext
    {
        public DSI2022v2Context()
        {
        }

        public DSI2022v2Context(DbContextOptions<DSI2022v2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<AsignacionCientificoDelCi> AsignacionCientificoDelCis { get; set; }
        public virtual DbSet<CambioEstadoRt> CambioEstadoRts { get; set; }
        public virtual DbSet<CambioEstadoTurno> CambioEstadoTurnos { get; set; }
        public virtual DbSet<CentroDeInvestigacion> CentroDeInvestigacions { get; set; }
        public virtual DbSet<Estado> Estados { get; set; }
        public virtual DbSet<Marca> Marcas { get; set; }
        public virtual DbSet<Modelo> Modelos { get; set; }
        public virtual DbSet<PersonalCientifico> PersonalCientificos { get; set; }
        public virtual DbSet<RecursoTecnologico> RecursoTecnologicos { get; set; }
        public virtual DbSet<Sesion> Sesions { get; set; }
        public virtual DbSet<TipoRt> TipoRts { get; set; }
        public virtual DbSet<Turno> Turnos { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=NALINO-PC\\SQLEXPRESS; Database=DSI2022v2; Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<AsignacionCientificoDelCi>(entity =>
            {
                entity.HasKey(e => e.IdAsignacion);

                entity.ToTable("AsignacionCientificoDelCI");

                entity.Property(e => e.IdAsignacion).HasColumnName("idAsignacion");

                entity.Property(e => e.CentroInvestigacion).HasColumnName("centroInvestigacion");

                entity.Property(e => e.FechaDesde)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaDesde");

                entity.Property(e => e.FechaHasta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaHasta");

                entity.Property(e => e.PersonalCientifico).HasColumnName("personalCientifico");

                entity.HasOne(d => d.CentroInvestigacionNavigation)
                    .WithMany(p => p.AsignacionCientificoDelCis)
                    .HasForeignKey(d => d.CentroInvestigacion)
                    .HasConstraintName("FK_AsignacionCientificoDelCI_CentroDeInvestigacion");

                entity.HasOne(d => d.PersonalCientificoNavigation)
                    .WithMany(p => p.AsignacionCientificoDelCis)
                    .HasForeignKey(d => d.PersonalCientifico)
                    .HasConstraintName("FK_AsignacionCientificoDelCI_PersonalCientifico");
            });

            modelBuilder.Entity<CambioEstadoRt>(entity =>
            {
                entity.HasKey(e => e.IdCambioRt);

                entity.ToTable("CambioEstadoRT");

                entity.Property(e => e.IdCambioRt).HasColumnName("idCambioRT");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaHoraDesde)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaHoraDesde");

                entity.Property(e => e.FechaHoraHasta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaHoraHasta");

                entity.Property(e => e.RecursoTecnologico).HasColumnName("recursoTecnologico");

                entity.HasOne(d => d.EstadoNavigation)
                    .WithMany(p => p.CambioEstadoRts)
                    .HasForeignKey(d => d.Estado)
                    .HasConstraintName("FK_CambioEstadoRT_Estado");

                entity.HasOne(d => d.RecursoTecnologicoNavigation)
                    .WithMany(p => p.CambioEstadoRts)
                    .HasForeignKey(d => d.RecursoTecnologico)
                    .HasConstraintName("FK_CambioEstadoRT_RecursoTecnologico");
            });

            modelBuilder.Entity<CambioEstadoTurno>(entity =>
            {
                entity.HasKey(e => e.IdCambioTurno);

                entity.ToTable("CambioEstadoTurno");

                entity.Property(e => e.IdCambioTurno).HasColumnName("idCambioTurno");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaHoraDesde)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaHoraDesde");

                entity.Property(e => e.FechaHoraHasta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaHoraHasta");

                entity.Property(e => e.Turno).HasColumnName("turno");

                entity.HasOne(d => d.EstadoNavigation)
                    .WithMany(p => p.CambioEstadoTurnos)
                    .HasForeignKey(d => d.Estado)
                    .HasConstraintName("FK_CambioEstadoTurno_Estado");

                entity.HasOne(d => d.TurnoNavigation)
                    .WithMany(p => p.CambioEstadoTurnos)
                    .HasForeignKey(d => d.Turno)
                    .HasConstraintName("FK_CambioEstadoTurno_Turno");
            });

            modelBuilder.Entity<CentroDeInvestigacion>(entity =>
            {
                entity.HasKey(e => e.IdCentro);

                entity.ToTable("CentroDeInvestigacion");

                entity.Property(e => e.IdCentro).HasColumnName("idCentro");

                entity.Property(e => e.CorreoElectronico)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("correoElectronico");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.FechaAlta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaAlta");

                entity.Property(e => e.FechaBaja)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaBaja");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.NumeroResolucionCreacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("numeroResolucionCreacion");

                entity.Property(e => e.TelefonoContacto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("telefonoContacto");
            });

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.HasKey(e => e.IdEstado);

                entity.ToTable("Estado");

                entity.Property(e => e.IdEstado)
                    .ValueGeneratedNever()
                    .HasColumnName("idEstado");

                entity.Property(e => e.Ambito)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ambito");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Marca>(entity =>
            {
                entity.HasKey(e => e.IdMarca);

                entity.ToTable("Marca");

                entity.Property(e => e.IdMarca).HasColumnName("idMarca");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Modelo>(entity =>
            {
                entity.HasKey(e => e.IdModelo);

                entity.ToTable("Modelo");

                entity.Property(e => e.IdModelo).HasColumnName("idModelo");

                entity.Property(e => e.Marca).HasColumnName("marca");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.HasOne(d => d.MarcaNavigation)
                    .WithMany(p => p.Modelos)
                    .HasForeignKey(d => d.Marca)
                    .HasConstraintName("FK_Modelo_Marca");
            });

            modelBuilder.Entity<PersonalCientifico>(entity =>
            {
                entity.HasKey(e => e.Legajo);

                entity.ToTable("PersonalCientifico");

                entity.Property(e => e.Legajo)
                    .ValueGeneratedNever()
                    .HasColumnName("legajo");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("apellido");

                entity.Property(e => e.Correo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.NumeroDocumento)
                    .HasColumnType("numeric(8, 0)")
                    .HasColumnName("numeroDocumento");

                entity.Property(e => e.TelefonoCelular)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("telefonoCelular");

                entity.Property(e => e.Usuario).HasColumnName("usuario");

                entity.HasOne(d => d.UsuarioNavigation)
                    .WithMany(p => p.PersonalCientificos)
                    .HasForeignKey(d => d.Usuario)
                    .HasConstraintName("FK_PersonalCientifico_Usuario");
            });

            modelBuilder.Entity<RecursoTecnologico>(entity =>
            {
                entity.HasKey(e => e.NumeroRt);

                entity.ToTable("RecursoTecnologico");

                entity.Property(e => e.NumeroRt)
                    .ValueGeneratedNever()
                    .HasColumnName("numeroRT");

                entity.Property(e => e.CentroInvestigacion).HasColumnName("centroInvestigacion");

                entity.Property(e => e.DuracionMantenimiento).HasColumnName("duracionMantenimiento");

                entity.Property(e => e.FechaAlta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaAlta");

                entity.Property(e => e.ModeloDelRt).HasColumnName("modeloDelRT");

                entity.Property(e => e.PeriodicidadMantenimiento).HasColumnName("periodicidadMantenimiento");

                entity.Property(e => e.TipoDeRt).HasColumnName("tipoDeRT");

                entity.HasOne(d => d.CentroInvestigacionNavigation)
                    .WithMany(p => p.RecursoTecnologicos)
                    .HasForeignKey(d => d.CentroInvestigacion)
                    .HasConstraintName("FK_RecursoTecnologico_CentroDeInvestigacion");

                entity.HasOne(d => d.ModeloDelRtNavigation)
                    .WithMany(p => p.RecursoTecnologicos)
                    .HasForeignKey(d => d.ModeloDelRt)
                    .HasConstraintName("FK_RecursoTecnologico_Modelo");

                entity.HasOne(d => d.TipoDeRtNavigation)
                    .WithMany(p => p.RecursoTecnologicos)
                    .HasForeignKey(d => d.TipoDeRt)
                    .HasConstraintName("FK_RecursoTecnologico_TipoRT");
            });

            modelBuilder.Entity<Sesion>(entity =>
            {
                entity.HasKey(e => e.IdSesion);

                entity.ToTable("Sesion");

                entity.Property(e => e.IdSesion).HasColumnName("idSesion");

                entity.Property(e => e.FechaHoraFin)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaHoraFin");

                entity.Property(e => e.FechaHoraInicio)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaHoraInicio");

                entity.Property(e => e.Usuario).HasColumnName("usuario");

                entity.HasOne(d => d.UsuarioNavigation)
                    .WithMany(p => p.Sesions)
                    .HasForeignKey(d => d.Usuario)
                    .HasConstraintName("FK_Sesion_Usuario");
            });

            modelBuilder.Entity<TipoRt>(entity =>
            {
                entity.HasKey(e => e.IdTipoRt);

                entity.ToTable("TipoRT");

                entity.Property(e => e.IdTipoRt).HasColumnName("idTipoRT");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Turno>(entity =>
            {
                entity.HasKey(e => e.IdTurno);

                entity.ToTable("Turno");

                entity.Property(e => e.IdTurno).HasColumnName("idTurno");

                entity.Property(e => e.Asignacion).HasColumnName("asignacion");

                entity.Property(e => e.DiaSemana).HasColumnName("diaSemana");

                entity.Property(e => e.FechaGeneracion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaGeneracion");

                entity.Property(e => e.FechaHoraFin)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaHoraFin");

                entity.Property(e => e.FechaHoraInicio)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaHoraInicio");

                entity.HasOne(d => d.AsignacionNavigation)
                    .WithMany(p => p.Turnos)
                    .HasForeignKey(d => d.Asignacion)
                    .HasConstraintName("FK_Turno_AsignacionCientificoDelCI");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);

                entity.ToTable("Usuario");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("clave");

                entity.Property(e => e.Habilitado).HasColumnName("habilitado");

                entity.Property(e => e.Usuario1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
