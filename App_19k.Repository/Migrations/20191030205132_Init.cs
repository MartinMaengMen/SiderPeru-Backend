using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App_19k.Repository.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departamentos",
                columns: table => new
                {
                    DepartamentoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NDepartamento = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamentos", x => x.DepartamentoId);
                });

            migrationBuilder.CreateTable(
                name: "Distribuidores",
                columns: table => new
                {
                    DistribuidorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NDistribuidor = table.Column<string>(nullable: true),
                    GrupoDistribuidor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distribuidores", x => x.DistribuidorId);
                });

            migrationBuilder.CreateTable(
                name: "MarcaProveedores",
                columns: table => new
                {
                    MarcaProveedorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NMarcaProveedor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarcaProveedores", x => x.MarcaProveedorId);
                });

            migrationBuilder.CreateTable(
                name: "Suministros",
                columns: table => new
                {
                    SuministroId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NSuministro = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suministros", x => x.SuministroId);
                });

            migrationBuilder.CreateTable(
                name: "Provincias",
                columns: table => new
                {
                    ProvinciaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NProvincia = table.Column<string>(nullable: true),
                    DepartamentoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provincias", x => x.ProvinciaId);
                    table.ForeignKey(
                        name: "FK_Provincias_Departamentos_DepartamentoId",
                        column: x => x.DepartamentoId,
                        principalTable: "Departamentos",
                        principalColumn: "DepartamentoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NUsuario = table.Column<string>(nullable: true),
                    TUserName = table.Column<string>(nullable: true),
                    TPassword = table.Column<string>(nullable: true),
                    DistribuidorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                    table.ForeignKey(
                        name: "FK_Usuarios_Distribuidores_DistribuidorId",
                        column: x => x.DistribuidorId,
                        principalTable: "Distribuidores",
                        principalColumn: "DistribuidorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Distritos",
                columns: table => new
                {
                    DistritoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NDistrito = table.Column<string>(nullable: true),
                    ProvinciaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distritos", x => x.DistritoId);
                    table.ForeignKey(
                        name: "FK_Distritos_Provincias_ProvinciaId",
                        column: x => x.ProvinciaId,
                        principalTable: "Provincias",
                        principalColumn: "ProvinciaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                 name: "Administradores",
                 columns: table => new
                 {
                     AdministradorId = table.Column<int>(nullable: false),
                     FAdminGeneral = table.Column<bool>(nullable: true),
                 },
                 constraints: table =>
                 {
                     table.PrimaryKey("PK_Administradores", x => x.AdministradorId);
                     table.ForeignKey(
                         name: "FK_Administradores_Usuarios",
                         column: x => x.AdministradorId,
                         principalTable: "Usuarios",
                         principalColumn: "UsuarioId",
                         onDelete: ReferentialAction.Restrict);
                 });
            migrationBuilder.CreateTable(
                name: "Vendedores",
                columns: table => new
                {
                    VendedorId = table.Column<int>(nullable: false),
                    TDni = table.Column<string>(nullable: true),
                    TEstado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendedores", x => x.VendedorId);
                    table.ForeignKey(
                        name: "FK_Vendedores_Usuarios_VendedorNavigationUsuarioId",
                        column: x => x.VendedorId,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Proyectos",
                columns: table => new
                {
                    ProyectoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NProyecto = table.Column<string>(nullable: true),
                    DistritoId = table.Column<int?>(nullable: true),
                    VendedorId = table.Column<int?>(nullable: true),
                    NumAreaTerreno = table.Column<decimal?>(nullable: true),
                    NumAreaTotal = table.Column<decimal?>(nullable: true),
                    TTipoInversion = table.Column<string>(nullable: true),
                    TEstatusProyecto = table.Column<string>(nullable: true),
                    TEstatusSolicitud = table.Column<string>(nullable: true),
                    NumLicencia = table.Column<string>(nullable: true),
                    DInicioSuministro = table.Column<DateTime?>(nullable: true),
                    FechaInscripcion = table.Column<DateTime?>(nullable: true),
                    NumTiempoSuministro = table.Column<int?>(nullable: true),
                    DFechaFinalObra = table.Column<DateTime?>(nullable: true),
                    TTipoSolicitud = table.Column<string>(nullable: true),
                    MPrecioSolicitado = table.Column<decimal?>(nullable: true),
                    NConstructora = table.Column<string>(nullable: true),
                    TRucConstructora = table.Column<string>(nullable: true),
                    IdentificadorSider = table.Column<string>(nullable: true),
                    FechaReg = table.Column<DateTime?>(nullable: true),
                    GrupoConstructora = table.Column<string>(nullable: true),
                    TDireccion = table.Column<string>(nullable: true),
                    MarcaProveedorId = table.Column<int?>(nullable: true),
                    NumToneladas = table.Column<decimal?>(nullable: true),
                    Latitud = table.Column<decimal>(nullable: true),
                    Altitud = table.Column<decimal>(nullable: true),
                    ObservacionProyecto = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proyectos", x => x.ProyectoId);
                    table.ForeignKey(
                        name: "FK_Proyectos_Distritos_DistritoId",
                        column: x => x.DistritoId,
                        principalTable: "Distritos",
                        principalColumn: "DistritoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Proyectos_MarcaProveedores_MarcaProveedorId",
                        column: x => x.MarcaProveedorId,
                        principalTable: "MarcaProveedores",
                        principalColumn: "MarcaProveedorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Proyectos_Vendedores_VendedorId",
                        column: x => x.VendedorId,
                        principalTable: "Vendedores",
                        principalColumn: "VendedorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActividadEconomicas",
                columns: table => new
                {
                    ActividadEconomicaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NActividadEconomica = table.Column<string>(nullable: true),
                    ProyectoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActividadEconomicas", x => x.ActividadEconomicaId);
                    table.ForeignKey(
                        name: "FK_ActividadEconomicas_Proyectos_ProyectoId",
                        column: x => x.ProyectoId,
                        principalTable: "Proyectos",
                        principalColumn: "ProyectoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetalleSuministros",
                columns: table => new
                {
                    DetalleSuministroId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SuministroId = table.Column<int>(nullable: false),
                    ProyectoId = table.Column<int>(nullable: false),
                    NumCantidad = table.Column<int>(nullable: false),
                    TTipoCantidad = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleSuministros", x => x.DetalleSuministroId);
                    table.ForeignKey(
                        name: "FK_DetalleSuministros_Proyectos_ProyectoId",
                        column: x => x.ProyectoId,
                        principalTable: "Proyectos",
                        principalColumn: "ProyectoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetalleSuministros_Suministros_SuministroId",
                        column: x => x.SuministroId,
                        principalTable: "Suministros",
                        principalColumn: "SuministroId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NumerosContactos",
                columns: table => new
                {
                    NumerosContactoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NumComu = table.Column<int>(nullable: false),
                    NombreContacto = table.Column<string>(nullable: true),
                    Tipo_Contacto = table.Column<string>(nullable: true),
                    ProyectoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NumerosContactos", x => x.NumerosContactoId);
                    table.ForeignKey(
                        name: "FK_NumerosContactos_Proyectos_ProyectoId",
                        column: x => x.ProyectoId,
                        principalTable: "Proyectos",
                        principalColumn: "ProyectoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Respuestas",
                columns: table => new
                {
                    RespuestaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MPrecioAutorizadoBase = table.Column<decimal>(nullable: false),
                    Flete = table.Column<decimal>(nullable: false),
                    DiasValidez = table.Column<int>(nullable: false),
                    FechaInicioOferta = table.Column<DateTime>(nullable: false),
                    FechaInicioVigenciaPrecio = table.Column<DateTime>(nullable: false),
                    FechaFinalVigenciaPrecio = table.Column<DateTime>(nullable: false),
                    ProyectoId = table.Column<int>(nullable: false),
                    FechaReg = table.Column<DateTime>(nullable: false),
                    fehab = table.Column<decimal>(nullable: false),
                    preciofehab = table.Column<decimal>(nullable: false),
                    observaciones = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Respuestas", x => x.RespuestaId);
                    table.ForeignKey(
                        name: "FK_Respuestas_Proyectos_ProyectoId",
                        column: x => x.ProyectoId,
                        principalTable: "Proyectos",
                        principalColumn: "ProyectoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Entregas",
                columns: table => new
                {
                    EntregaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DetalleSuministroId = table.Column<int>(nullable: false),
                    Cantidad = table.Column<int>(nullable: false),
                    DFechaEntrega = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entregas", x => x.EntregaId);
                    table.ForeignKey(
                        name: "FK_Entregas_DetalleSuministros_DetalleSuministroId",
                        column: x => x.DetalleSuministroId,
                        principalTable: "DetalleSuministros",
                        principalColumn: "DetalleSuministroId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActividadEconomicas_ProyectoId",
                table: "ActividadEconomicas",
                column: "ProyectoId");

            migrationBuilder.CreateIndex(
               name: "IX_Administradores_AdministradorId",
               table: "Administradores",
               column: "AdministradorId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleSuministros_ProyectoId",
                table: "DetalleSuministros",
                column: "ProyectoId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleSuministros_SuministroId",
                table: "DetalleSuministros",
                column: "SuministroId");

            migrationBuilder.CreateIndex(
                name: "IX_Distritos_ProvinciaId",
                table: "Distritos",
                column: "ProvinciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Entregas_DetalleSuministroId",
                table: "Entregas",
                column: "DetalleSuministroId");

            migrationBuilder.CreateIndex(
                name: "IX_NumerosContactos_ProyectoId",
                table: "NumerosContactos",
                column: "ProyectoId");

            migrationBuilder.CreateIndex(
                name: "IX_Provincias_DepartamentoId",
                table: "Provincias",
                column: "DepartamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Proyectos_DistritoId",
                table: "Proyectos",
                column: "DistritoId");

            migrationBuilder.CreateIndex(
                name: "IX_Proyectos_MarcaProveedorId",
                table: "Proyectos",
                column: "MarcaProveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Proyectos_VendedorId",
                table: "Proyectos",
                column: "VendedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Respuestas_ProyectoId",
                table: "Respuestas",
                column: "ProyectoId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_DistribuidorId",
                table: "Usuarios",
                column: "DistribuidorId");

            migrationBuilder.CreateIndex(
          name: "IX_Vendedores_VendedorNavigation",
          table: "Vendedores",
          column: "VendedorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActividadEconomicas");

            migrationBuilder.DropTable(
                name: "Administradores");

            migrationBuilder.DropTable(
                name: "Entregas");

            migrationBuilder.DropTable(
                name: "NumerosContactos");

            migrationBuilder.DropTable(
                name: "Respuestas");

            migrationBuilder.DropTable(
                name: "DetalleSuministros");

            migrationBuilder.DropTable(
                name: "Proyectos");

            migrationBuilder.DropTable(
                name: "Suministros");

            migrationBuilder.DropTable(
                name: "Distritos");

            migrationBuilder.DropTable(
                name: "MarcaProveedores");

            migrationBuilder.DropTable(
                name: "Vendedores");

            migrationBuilder.DropTable(
                name: "Provincias");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Departamentos");

            migrationBuilder.DropTable(
                name: "Distribuidores");
        }
    }
}
