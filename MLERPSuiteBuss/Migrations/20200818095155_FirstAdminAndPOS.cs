using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MLERPSuiteBuss.Migrations
{
    public partial class FirstAdminAndPOS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdminLanguage",
                columns: table => new
                {
                    LanguageId = table.Column<int>(nullable: false),
                    LanguageDescription = table.Column<string>(nullable: false),
                    IsRightToLeft = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminLanguage", x => x.LanguageId);
                });

            migrationBuilder.CreateTable(
                name: "AdminModule",
                columns: table => new
                {
                    ModuleId = table.Column<int>(nullable: false),
                    ModuleCode = table.Column<string>(nullable: false),
                    ModuleOrder = table.Column<int>(nullable: false),
                    ModuleURL = table.Column<string>(nullable: false),
                    ModuleIcon = table.Column<string>(nullable: false),
                    IsDisabled = table.Column<byte>(nullable: false),
                    Records3DigitsPrefix = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminModule", x => x.ModuleId);
                });

            migrationBuilder.CreateTable(
                name: "AdminObject",
                columns: table => new
                {
                    ObjectId = table.Column<int>(nullable: false),
                    ObjectDescription = table.Column<string>(nullable: false),
                    IsFixedList = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminObject", x => x.ObjectId);
                });

            migrationBuilder.CreateTable(
                name: "AdminPackage",
                columns: table => new
                {
                    PackageId = table.Column<int>(nullable: false),
                    PackageMonthlyPrice = table.Column<decimal>(type: "decimal(18,3)", nullable: false),
                    PackageYearlyPrice = table.Column<decimal>(type: "decimal(18,3)", nullable: false),
                    DemoForMonthCount = table.Column<int>(nullable: false),
                    IsFree = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminPackage", x => x.PackageId);
                });

            migrationBuilder.CreateTable(
                name: "AdminRight",
                columns: table => new
                {
                    RightId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminRight", x => x.RightId);
                });

            migrationBuilder.CreateTable(
                name: "AdminScreenLevel",
                columns: table => new
                {
                    ScreenLevelId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminScreenLevel", x => x.ScreenLevelId);
                });

            migrationBuilder.CreateTable(
                name: "AdminTenant",
                columns: table => new
                {
                    TenantId = table.Column<int>(nullable: false),
                    TenantDescription = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminTenant", x => x.TenantId);
                });

            migrationBuilder.CreateTable(
                name: "AdminWFStepStatus",
                columns: table => new
                {
                    StepStatusId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminWFStepStatus", x => x.StepStatusId);
                });

            migrationBuilder.CreateTable(
                name: "AdminWFTransStatus",
                columns: table => new
                {
                    TransStatusId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminWFTransStatus", x => x.TransStatusId);
                });

            migrationBuilder.CreateTable(
                name: "InvPOSReturnType",
                columns: table => new
                {
                    InvPOSReturnTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvPOSReturnType", x => x.InvPOSReturnTypeId);
                });

            migrationBuilder.CreateTable(
                name: "InvPOSSalesType",
                columns: table => new
                {
                    InvPOSSalesTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvPOSSalesType", x => x.InvPOSSalesTypeId);
                });

            migrationBuilder.CreateTable(
                name: "AdminPackageModule",
                columns: table => new
                {
                    PackageId = table.Column<int>(nullable: false),
                    ModuleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminPackageModule", x => new { x.PackageId, x.ModuleId });
                    table.ForeignKey(
                        name: "FK_AdminPackageModule_AdminModule_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "AdminModule",
                        principalColumn: "ModuleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AdminPackageModule_AdminPackage_PackageId",
                        column: x => x.PackageId,
                        principalTable: "AdminPackage",
                        principalColumn: "PackageId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AdminScreen",
                columns: table => new
                {
                    ScreenId = table.Column<int>(nullable: false),
                    RightId = table.Column<int>(nullable: false),
                    ScreenParentId = table.Column<int>(nullable: true),
                    ScreenLevelId = table.Column<int>(nullable: false),
                    ScreenLevelId1 = table.Column<int>(nullable: false),
                    ScreenLevelId2 = table.Column<int>(nullable: false),
                    ScreenLevelId3 = table.Column<int>(nullable: false),
                    ScreenLevelId4 = table.Column<int>(nullable: false),
                    ScreenIsLeaf = table.Column<byte>(nullable: false),
                    ScreenOrder = table.Column<int>(nullable: false),
                    ScreenURL = table.Column<string>(nullable: false),
                    ScreenMode = table.Column<string>(nullable: true),
                    ScreenIcon = table.Column<string>(nullable: false),
                    IsDisabled = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminScreen", x => x.ScreenId);
                    table.ForeignKey(
                        name: "FK_AdminScreen_AdminRight_RightId",
                        column: x => x.RightId,
                        principalTable: "AdminRight",
                        principalColumn: "RightId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AdminScreen_AdminScreenLevel_ScreenLevelId",
                        column: x => x.ScreenLevelId,
                        principalTable: "AdminScreenLevel",
                        principalColumn: "ScreenLevelId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AdminScreen_AdminScreen_ScreenParentId",
                        column: x => x.ScreenParentId,
                        principalTable: "AdminScreen",
                        principalColumn: "ScreenId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AdminActor",
                columns: table => new
                {
                    TenantId = table.Column<int>(nullable: false),
                    ActorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminActor", x => new { x.TenantId, x.ActorId });
                    table.ForeignKey(
                        name: "FK_AdminActor_AdminTenant_TenantId",
                        column: x => x.TenantId,
                        principalTable: "AdminTenant",
                        principalColumn: "TenantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdminChartLevel",
                columns: table => new
                {
                    TenantId = table.Column<int>(nullable: false),
                    ChartLevelId = table.Column<int>(nullable: false),
                    ChartCodeLength = table.Column<byte>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    EditedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    EditedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminChartLevel", x => new { x.TenantId, x.ChartLevelId });
                    table.ForeignKey(
                        name: "FK_AdminChartLevel_AdminTenant_TenantId",
                        column: x => x.TenantId,
                        principalTable: "AdminTenant",
                        principalColumn: "TenantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdminCountry",
                columns: table => new
                {
                    TenantId = table.Column<int>(nullable: false),
                    CountryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminCountry", x => new { x.TenantId, x.CountryId });
                    table.ForeignKey(
                        name: "FK_AdminCountry_AdminTenant_TenantId",
                        column: x => x.TenantId,
                        principalTable: "AdminTenant",
                        principalColumn: "TenantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdminCurrency",
                columns: table => new
                {
                    TenantId = table.Column<int>(nullable: false),
                    CurrencyId = table.Column<int>(nullable: false),
                    CurrencyCode = table.Column<string>(nullable: false),
                    DigitCount = table.Column<byte>(nullable: false),
                    IsLocalCurrency = table.Column<byte>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    EditedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    EditedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminCurrency", x => new { x.TenantId, x.CurrencyId });
                    table.ForeignKey(
                        name: "FK_AdminCurrency_AdminTenant_TenantId",
                        column: x => x.TenantId,
                        principalTable: "AdminTenant",
                        principalColumn: "TenantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdminNationality",
                columns: table => new
                {
                    TenantId = table.Column<int>(nullable: false),
                    NationalityId = table.Column<int>(nullable: false),
                    NationalityCode = table.Column<string>(nullable: false),
                    IsLocalNationality = table.Column<byte>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    EditedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    EditedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminNationality", x => new { x.TenantId, x.NationalityId });
                    table.ForeignKey(
                        name: "FK_AdminNationality_AdminTenant_TenantId",
                        column: x => x.TenantId,
                        principalTable: "AdminTenant",
                        principalColumn: "TenantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdminNotes",
                columns: table => new
                {
                    TenantId = table.Column<int>(nullable: false),
                    NoteId = table.Column<int>(nullable: false),
                    NoteDescription = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminNotes", x => new { x.TenantId, x.NoteId });
                    table.ForeignKey(
                        name: "FK_AdminNotes_AdminTenant_TenantId",
                        column: x => x.TenantId,
                        principalTable: "AdminTenant",
                        principalColumn: "TenantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdminObjectLanguage",
                columns: table => new
                {
                    TenantId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false),
                    ObjectId = table.Column<int>(nullable: false),
                    RowId = table.Column<int>(nullable: false),
                    RowDescription = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminObjectLanguage", x => new { x.TenantId, x.LanguageId, x.ObjectId, x.RowId });
                    table.ForeignKey(
                        name: "FK_AdminObjectLanguage_AdminLanguage_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "AdminLanguage",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AdminObjectLanguage_AdminObject_ObjectId",
                        column: x => x.ObjectId,
                        principalTable: "AdminObject",
                        principalColumn: "ObjectId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AdminObjectLanguage_AdminTenant_TenantId",
                        column: x => x.TenantId,
                        principalTable: "AdminTenant",
                        principalColumn: "TenantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdminTenantLanguage",
                columns: table => new
                {
                    TenantId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    EditedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    EditedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminTenantLanguage", x => new { x.TenantId, x.LanguageId });
                    table.ForeignKey(
                        name: "FK_AdminTenantLanguage_AdminLanguage_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "AdminLanguage",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AdminTenantLanguage_AdminTenant_TenantId",
                        column: x => x.TenantId,
                        principalTable: "AdminTenant",
                        principalColumn: "TenantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdminTenantPackage",
                columns: table => new
                {
                    TenantId = table.Column<int>(nullable: false),
                    PackageId = table.Column<int>(nullable: false),
                    LastPrice = table.Column<decimal>(type: "decimal(18,3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminTenantPackage", x => new { x.TenantId, x.PackageId });
                    table.ForeignKey(
                        name: "FK_AdminTenantPackage_AdminPackage_PackageId",
                        column: x => x.PackageId,
                        principalTable: "AdminPackage",
                        principalColumn: "PackageId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AdminTenantPackage_AdminTenant_TenantId",
                        column: x => x.TenantId,
                        principalTable: "AdminTenant",
                        principalColumn: "TenantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InvItemCategoryLevel",
                columns: table => new
                {
                    TenantId = table.Column<int>(nullable: false),
                    CatLevelId = table.Column<int>(nullable: false),
                    CatCodeLength = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    EditedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    EditedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvItemCategoryLevel", x => new { x.TenantId, x.CatLevelId });
                    table.ForeignKey(
                        name: "FK_InvItemCategoryLevel_AdminTenant_TenantId",
                        column: x => x.TenantId,
                        principalTable: "AdminTenant",
                        principalColumn: "TenantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InvItemUnitOfMeasure",
                columns: table => new
                {
                    TenantId = table.Column<int>(nullable: false),
                    UnitId = table.Column<int>(nullable: false),
                    UnitCode = table.Column<string>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    EditedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    EditedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvItemUnitOfMeasure", x => new { x.TenantId, x.UnitId });
                    table.ForeignKey(
                        name: "FK_InvItemUnitOfMeasure_AdminTenant_TenantId",
                        column: x => x.TenantId,
                        principalTable: "AdminTenant",
                        principalColumn: "TenantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InvLocationLevel",
                columns: table => new
                {
                    TenantId = table.Column<int>(nullable: false),
                    LocationLevelId = table.Column<int>(nullable: false),
                    LocationCodeLength = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    EditedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    EditedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvLocationLevel", x => new { x.TenantId, x.LocationLevelId });
                    table.ForeignKey(
                        name: "FK_InvLocationLevel_AdminTenant_TenantId",
                        column: x => x.TenantId,
                        principalTable: "AdminTenant",
                        principalColumn: "TenantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InvPOSSalesPaymentMethod",
                columns: table => new
                {
                    TenantId = table.Column<int>(nullable: false),
                    PaymentMethodId = table.Column<int>(nullable: false),
                    PaymentMethodCode = table.Column<string>(nullable: false),
                    PaymentMethodRef = table.Column<string>(nullable: true),
                    IsKeyNet = table.Column<byte>(nullable: false),
                    IsMasterCard = table.Column<byte>(nullable: false),
                    IsVoucher = table.Column<byte>(nullable: false),
                    IsDisabled = table.Column<byte>(nullable: false),
                    NoteId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    EditedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    EditedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvPOSSalesPaymentMethod", x => new { x.TenantId, x.PaymentMethodId });
                    table.ForeignKey(
                        name: "FK_InvPOSSalesPaymentMethod_AdminTenant_TenantId",
                        column: x => x.TenantId,
                        principalTable: "AdminTenant",
                        principalColumn: "TenantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InvPriceHeader",
                columns: table => new
                {
                    TenantId = table.Column<int>(nullable: false),
                    PriceListId = table.Column<int>(nullable: false),
                    PriceListCode = table.Column<string>(nullable: false),
                    PriceListRef = table.Column<string>(nullable: true),
                    NoteId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    EditedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    EditedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvPriceHeader", x => new { x.TenantId, x.PriceListId });
                    table.ForeignKey(
                        name: "FK_InvPriceHeader_AdminTenant_TenantId",
                        column: x => x.TenantId,
                        principalTable: "AdminTenant",
                        principalColumn: "TenantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdminModuleScreen",
                columns: table => new
                {
                    ModuleId = table.Column<int>(nullable: false),
                    ScreenId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminModuleScreen", x => new { x.ModuleId, x.ScreenId });
                    table.ForeignKey(
                        name: "FK_AdminModuleScreen_AdminModule_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "AdminModule",
                        principalColumn: "ModuleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AdminModuleScreen_AdminScreen_ScreenId",
                        column: x => x.ScreenId,
                        principalTable: "AdminScreen",
                        principalColumn: "ScreenId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AdminScreenLanguage",
                columns: table => new
                {
                    ScreenId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false),
                    LabelId = table.Column<string>(nullable: false),
                    Caption = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminScreenLanguage", x => new { x.ScreenId, x.LanguageId, x.LabelId });
                    table.ForeignKey(
                        name: "FK_AdminScreenLanguage_AdminLanguage_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "AdminLanguage",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AdminScreenLanguage_AdminScreen_ScreenId",
                        column: x => x.ScreenId,
                        principalTable: "AdminScreen",
                        principalColumn: "ScreenId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AdminWFMaster",
                columns: table => new
                {
                    WorkFlowId = table.Column<int>(nullable: false),
                    ModuleId = table.Column<int>(nullable: false),
                    ScreenId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminWFMaster", x => x.WorkFlowId);
                    table.ForeignKey(
                        name: "FK_AdminWFMaster_AdminScreen_ScreenId",
                        column: x => x.ScreenId,
                        principalTable: "AdminScreen",
                        principalColumn: "ScreenId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AdminWFMaster_AdminModule_WorkFlowId",
                        column: x => x.WorkFlowId,
                        principalTable: "AdminModule",
                        principalColumn: "ModuleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AdminChart",
                columns: table => new
                {
                    TenantId = table.Column<int>(nullable: false),
                    ChartId = table.Column<int>(nullable: false),
                    ChartCode = table.Column<string>(nullable: false),
                    ChartRef = table.Column<string>(nullable: true),
                    ChartParentId = table.Column<int>(nullable: true),
                    ChartLevelId = table.Column<int>(nullable: false),
                    ChartLevelId1 = table.Column<int>(nullable: false),
                    ChartLevelId2 = table.Column<int>(nullable: false),
                    ChartLevelId3 = table.Column<int>(nullable: false),
                    ChartLevelId4 = table.Column<int>(nullable: false),
                    ChartLevelId5 = table.Column<int>(nullable: false),
                    ChartLevelId6 = table.Column<int>(nullable: false),
                    ChartIsLeaf = table.Column<byte>(nullable: false),
                    NoteId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    EditedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    EditedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminChart", x => new { x.TenantId, x.ChartId });
                    table.ForeignKey(
                        name: "FK_AdminChart_AdminTenant_TenantId",
                        column: x => x.TenantId,
                        principalTable: "AdminTenant",
                        principalColumn: "TenantId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdminChart_AdminChartLevel_TenantId_ChartLevelId",
                        columns: x => new { x.TenantId, x.ChartLevelId },
                        principalTable: "AdminChartLevel",
                        principalColumns: new[] { "TenantId", "ChartLevelId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AdminChart_AdminChart_TenantId_ChartParentId",
                        columns: x => new { x.TenantId, x.ChartParentId },
                        principalTable: "AdminChart",
                        principalColumns: new[] { "TenantId", "ChartId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AdminProvince",
                columns: table => new
                {
                    TenantId = table.Column<int>(nullable: false),
                    ProvinceId = table.Column<int>(nullable: false),
                    CountryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminProvince", x => new { x.TenantId, x.ProvinceId });
                    table.ForeignKey(
                        name: "FK_AdminProvince_AdminTenant_TenantId",
                        column: x => x.TenantId,
                        principalTable: "AdminTenant",
                        principalColumn: "TenantId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdminProvince_AdminCountry_TenantId_CountryId",
                        columns: x => new { x.TenantId, x.CountryId },
                        principalTable: "AdminCountry",
                        principalColumns: new[] { "TenantId", "CountryId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InvItemCategory",
                columns: table => new
                {
                    TenantId = table.Column<int>(nullable: false),
                    CatId = table.Column<int>(nullable: false),
                    CatCode = table.Column<string>(nullable: false),
                    CatRef = table.Column<string>(nullable: true),
                    CatParentId = table.Column<int>(nullable: true),
                    CatLevelId = table.Column<int>(nullable: false),
                    CatLevelId1 = table.Column<int>(nullable: false),
                    CatLevelId2 = table.Column<int>(nullable: false),
                    CatLevelId3 = table.Column<int>(nullable: false),
                    CatLevelId4 = table.Column<int>(nullable: false),
                    CatLevelId5 = table.Column<int>(nullable: false),
                    CatLevelId6 = table.Column<int>(nullable: false),
                    CatIsLeaf = table.Column<byte>(nullable: false),
                    NoteId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    EditedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    EditedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvItemCategory", x => new { x.TenantId, x.CatId });
                    table.ForeignKey(
                        name: "FK_InvItemCategory_AdminTenant_TenantId",
                        column: x => x.TenantId,
                        principalTable: "AdminTenant",
                        principalColumn: "TenantId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvItemCategory_InvItemCategoryLevel_TenantId_CatLevelId",
                        columns: x => new { x.TenantId, x.CatLevelId },
                        principalTable: "InvItemCategoryLevel",
                        principalColumns: new[] { "TenantId", "CatLevelId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvItemCategory_InvItemCategory_TenantId_CatParentId",
                        columns: x => new { x.TenantId, x.CatParentId },
                        principalTable: "InvItemCategory",
                        principalColumns: new[] { "TenantId", "CatId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InvLocation",
                columns: table => new
                {
                    TenantId = table.Column<int>(nullable: false),
                    LocationId = table.Column<int>(nullable: false),
                    LocationCode = table.Column<string>(nullable: false),
                    LocationRef = table.Column<string>(nullable: true),
                    LocationParentId = table.Column<int>(nullable: true),
                    LocationLevelId = table.Column<int>(nullable: false),
                    LocationLevelId1 = table.Column<int>(nullable: false),
                    LocationLevelId2 = table.Column<int>(nullable: false),
                    LocationLevelId3 = table.Column<int>(nullable: false),
                    LocationLevelId4 = table.Column<int>(nullable: false),
                    LocationLevelId5 = table.Column<int>(nullable: false),
                    LocationLevelId6 = table.Column<int>(nullable: false),
                    LocationIsLeaf = table.Column<byte>(nullable: false),
                    PriceListId = table.Column<int>(nullable: true),
                    NoteId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    EditedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    EditedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvLocation", x => new { x.TenantId, x.LocationId });
                    table.ForeignKey(
                        name: "FK_InvLocation_AdminTenant_TenantId",
                        column: x => x.TenantId,
                        principalTable: "AdminTenant",
                        principalColumn: "TenantId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvLocation_InvLocationLevel_TenantId_LocationLevelId",
                        columns: x => new { x.TenantId, x.LocationLevelId },
                        principalTable: "InvLocationLevel",
                        principalColumns: new[] { "TenantId", "LocationLevelId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvLocation_InvLocation_TenantId_LocationParentId",
                        columns: x => new { x.TenantId, x.LocationParentId },
                        principalTable: "InvLocation",
                        principalColumns: new[] { "TenantId", "LocationId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvLocation_InvPriceHeader_TenantId_PriceListId",
                        columns: x => new { x.TenantId, x.PriceListId },
                        principalTable: "InvPriceHeader",
                        principalColumns: new[] { "TenantId", "PriceListId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AdminWFDocument",
                columns: table => new
                {
                    TenantId = table.Column<int>(nullable: false),
                    WorkFlowId = table.Column<int>(nullable: false),
                    DocumentId = table.Column<int>(nullable: false),
                    IsDisabled = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminWFDocument", x => new { x.TenantId, x.WorkFlowId, x.DocumentId });
                    table.ForeignKey(
                        name: "FK_AdminWFDocument_AdminTenant_TenantId",
                        column: x => x.TenantId,
                        principalTable: "AdminTenant",
                        principalColumn: "TenantId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdminWFDocument_AdminWFMaster_WorkFlowId",
                        column: x => x.WorkFlowId,
                        principalTable: "AdminWFMaster",
                        principalColumn: "WorkFlowId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AdminUser",
                columns: table => new
                {
                    TenantId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    UserFullName = table.Column<string>(nullable: false),
                    LoginUserName = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    IsDisabled = table.Column<byte>(nullable: false),
                    IsAdmin = table.Column<byte>(nullable: false),
                    ChartId = table.Column<int>(nullable: false),
                    NoteId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    EditedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    EditedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminUser", x => new { x.TenantId, x.UserId });
                    table.ForeignKey(
                        name: "FK_AdminUser_AdminTenant_TenantId",
                        column: x => x.TenantId,
                        principalTable: "AdminTenant",
                        principalColumn: "TenantId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdminUser_AdminChart_TenantId_ChartId",
                        columns: x => new { x.TenantId, x.ChartId },
                        principalTable: "AdminChart",
                        principalColumns: new[] { "TenantId", "ChartId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AdminTown",
                columns: table => new
                {
                    TenantId = table.Column<int>(nullable: false),
                    TownId = table.Column<int>(nullable: false),
                    ProvinceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminTown", x => new { x.TenantId, x.TownId });
                    table.ForeignKey(
                        name: "FK_AdminTown_AdminTenant_TenantId",
                        column: x => x.TenantId,
                        principalTable: "AdminTenant",
                        principalColumn: "TenantId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdminTown_AdminProvince_TenantId_ProvinceId",
                        columns: x => new { x.TenantId, x.ProvinceId },
                        principalTable: "AdminProvince",
                        principalColumns: new[] { "TenantId", "ProvinceId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InvItemMaster",
                columns: table => new
                {
                    TenantId = table.Column<int>(nullable: false),
                    ItemId = table.Column<int>(nullable: false),
                    ItemCode = table.Column<string>(nullable: false),
                    ItemRef = table.Column<string>(nullable: true),
                    ItemCode1 = table.Column<string>(nullable: true),
                    ItemCode2 = table.Column<string>(nullable: true),
                    IsDisabled = table.Column<byte>(nullable: false),
                    CatId = table.Column<int>(nullable: false),
                    NoteId = table.Column<int>(nullable: false),
                    BaseUnitIdCashed = table.Column<int>(nullable: false),
                    BigUnitIdCashed = table.Column<int>(nullable: false),
                    BaseToBigFactorCashed = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    BigToBaseFactorCashed = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    EditedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    EditedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvItemMaster", x => new { x.TenantId, x.ItemId });
                    table.ForeignKey(
                        name: "FK_InvItemMaster_AdminTenant_TenantId",
                        column: x => x.TenantId,
                        principalTable: "AdminTenant",
                        principalColumn: "TenantId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvItemMaster_InvItemCategory_TenantId_CatId",
                        columns: x => new { x.TenantId, x.CatId },
                        principalTable: "InvItemCategory",
                        principalColumns: new[] { "TenantId", "CatId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InvPOSTerminal",
                columns: table => new
                {
                    TenantId = table.Column<int>(nullable: false),
                    TerminalId = table.Column<int>(nullable: false),
                    TerminalCode = table.Column<string>(nullable: false),
                    TerminalRef = table.Column<string>(nullable: true),
                    LocationId = table.Column<int>(nullable: false),
                    NoteId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    EditedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    EditedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvPOSTerminal", x => new { x.TenantId, x.TerminalId });
                    table.ForeignKey(
                        name: "FK_InvPOSTerminal_AdminTenant_TenantId",
                        column: x => x.TenantId,
                        principalTable: "AdminTenant",
                        principalColumn: "TenantId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvPOSTerminal_InvLocation_TenantId_LocationId",
                        columns: x => new { x.TenantId, x.LocationId },
                        principalTable: "InvLocation",
                        principalColumns: new[] { "TenantId", "LocationId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AdminCoding",
                columns: table => new
                {
                    TenantId = table.Column<int>(nullable: false),
                    DocumentId = table.Column<int>(nullable: false),
                    WorkFlowId = table.Column<int>(nullable: false),
                    NumberLength = table.Column<int>(nullable: false),
                    SplitCharcter = table.Column<string>(nullable: false),
                    WithPrefix = table.Column<int>(nullable: false),
                    PrefixCode = table.Column<string>(nullable: false),
                    WithMonthYear = table.Column<int>(nullable: false),
                    WithLocation = table.Column<string>(nullable: false),
                    CurrentNumber = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminCoding", x => new { x.TenantId, x.DocumentId });
                    table.ForeignKey(
                        name: "FK_AdminCoding_AdminTenant_TenantId",
                        column: x => x.TenantId,
                        principalTable: "AdminTenant",
                        principalColumn: "TenantId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdminCoding_AdminWFMaster_WorkFlowId",
                        column: x => x.WorkFlowId,
                        principalTable: "AdminWFMaster",
                        principalColumn: "WorkFlowId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AdminCoding_AdminWFDocument_TenantId_WorkFlowId_DocumentId",
                        columns: x => new { x.TenantId, x.WorkFlowId, x.DocumentId },
                        principalTable: "AdminWFDocument",
                        principalColumns: new[] { "TenantId", "WorkFlowId", "DocumentId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AdminWFStep",
                columns: table => new
                {
                    TenantId = table.Column<int>(nullable: false),
                    StepId = table.Column<int>(nullable: false),
                    WorkFlowId = table.Column<int>(nullable: false),
                    ActorId = table.Column<int>(nullable: false),
                    NextStepId = table.Column<int>(nullable: true),
                    DocumentId = table.Column<int>(nullable: true),
                    IsFirstStep = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminWFStep", x => new { x.TenantId, x.StepId });
                    table.ForeignKey(
                        name: "FK_AdminWFStep_AdminTenant_TenantId",
                        column: x => x.TenantId,
                        principalTable: "AdminTenant",
                        principalColumn: "TenantId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdminWFStep_AdminWFMaster_WorkFlowId",
                        column: x => x.WorkFlowId,
                        principalTable: "AdminWFMaster",
                        principalColumn: "WorkFlowId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AdminWFStep_AdminActor_TenantId_ActorId",
                        columns: x => new { x.TenantId, x.ActorId },
                        principalTable: "AdminActor",
                        principalColumns: new[] { "TenantId", "ActorId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AdminWFStep_AdminWFStep_TenantId_NextStepId",
                        columns: x => new { x.TenantId, x.NextStepId },
                        principalTable: "AdminWFStep",
                        principalColumns: new[] { "TenantId", "StepId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AdminWFStep_AdminWFDocument_TenantId_WorkFlowId_DocumentId",
                        columns: x => new { x.TenantId, x.WorkFlowId, x.DocumentId },
                        principalTable: "AdminWFDocument",
                        principalColumns: new[] { "TenantId", "WorkFlowId", "DocumentId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AdminWFTransList",
                columns: table => new
                {
                    TenantId = table.Column<int>(nullable: false),
                    WorkFlowId = table.Column<int>(nullable: false),
                    CurrentTransId = table.Column<int>(nullable: false),
                    HeaderGuidId = table.Column<Guid>(nullable: false),
                    TransStatusId = table.Column<int>(nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    TransactionCode = table.Column<string>(nullable: false),
                    DocumentId = table.Column<int>(nullable: false),
                    ErrorId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    EditedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    EditedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminWFTransList", x => new { x.TenantId, x.WorkFlowId, x.CurrentTransId });
                    table.ForeignKey(
                        name: "FK_AdminWFTransList_AdminTenant_TenantId",
                        column: x => x.TenantId,
                        principalTable: "AdminTenant",
                        principalColumn: "TenantId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdminWFTransList_AdminWFTransStatus_TransStatusId",
                        column: x => x.TransStatusId,
                        principalTable: "AdminWFTransStatus",
                        principalColumn: "TransStatusId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AdminWFTransList_AdminWFMaster_WorkFlowId",
                        column: x => x.WorkFlowId,
                        principalTable: "AdminWFMaster",
                        principalColumn: "WorkFlowId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AdminWFTransList_AdminWFDocument_TenantId_WorkFlowId_DocumentId",
                        columns: x => new { x.TenantId, x.WorkFlowId, x.DocumentId },
                        principalTable: "AdminWFDocument",
                        principalColumns: new[] { "TenantId", "WorkFlowId", "DocumentId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InvCustomer",
                columns: table => new
                {
                    TenantId = table.Column<int>(nullable: false),
                    CustId = table.Column<int>(nullable: false),
                    CustCode = table.Column<string>(nullable: false),
                    CustRef = table.Column<string>(nullable: true),
                    IsDisabled = table.Column<byte>(nullable: false),
                    CustTelNo = table.Column<string>(nullable: true),
                    CustMobileNo = table.Column<string>(nullable: true),
                    CustFaxNo = table.Column<string>(nullable: true),
                    CustEmail1 = table.Column<string>(nullable: true),
                    CustWebsite = table.Column<string>(nullable: true),
                    CustContactPerson = table.Column<string>(nullable: true),
                    CustFullAddress = table.Column<string>(nullable: true),
                    ProvinceId = table.Column<int>(nullable: true),
                    TownId = table.Column<int>(nullable: true),
                    BlockNo = table.Column<int>(nullable: false),
                    StreetNo = table.Column<string>(nullable: true),
                    BuildingNo = table.Column<string>(nullable: true),
                    FlatNo = table.Column<string>(nullable: true),
                    NoteId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    EditedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    EditedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvCustomer", x => new { x.TenantId, x.CustId });
                    table.ForeignKey(
                        name: "FK_InvCustomer_AdminTenant_TenantId",
                        column: x => x.TenantId,
                        principalTable: "AdminTenant",
                        principalColumn: "TenantId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvCustomer_AdminProvince_TenantId_ProvinceId",
                        columns: x => new { x.TenantId, x.ProvinceId },
                        principalTable: "AdminProvince",
                        principalColumns: new[] { "TenantId", "ProvinceId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvCustomer_AdminTown_TenantId_TownId",
                        columns: x => new { x.TenantId, x.TownId },
                        principalTable: "AdminTown",
                        principalColumns: new[] { "TenantId", "TownId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InvItemUnit",
                columns: table => new
                {
                    TenantId = table.Column<int>(nullable: false),
                    ItemId = table.Column<int>(nullable: false),
                    UnitId = table.Column<int>(nullable: false),
                    FactorToBaseUnit = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    IsBaseUnit = table.Column<byte>(nullable: false),
                    IsDisabled = table.Column<byte>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    EditedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    EditedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvItemUnit", x => new { x.TenantId, x.ItemId, x.UnitId });
                    table.ForeignKey(
                        name: "FK_InvItemUnit_AdminTenant_TenantId",
                        column: x => x.TenantId,
                        principalTable: "AdminTenant",
                        principalColumn: "TenantId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvItemUnit_InvItemMaster_TenantId_ItemId",
                        columns: x => new { x.TenantId, x.ItemId },
                        principalTable: "InvItemMaster",
                        principalColumns: new[] { "TenantId", "ItemId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvItemUnit_InvItemUnitOfMeasure_TenantId_UnitId",
                        columns: x => new { x.TenantId, x.UnitId },
                        principalTable: "InvItemUnitOfMeasure",
                        principalColumns: new[] { "TenantId", "UnitId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InvPOSZread",
                columns: table => new
                {
                    TenantId = table.Column<int>(nullable: false),
                    ZreadId = table.Column<int>(nullable: false),
                    WorkFlowId = table.Column<int>(nullable: false),
                    DocumentId = table.Column<int>(nullable: false),
                    TransStatusId = table.Column<int>(nullable: false),
                    ZreadCode = table.Column<string>(nullable: false),
                    ZreadDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    TerminalId = table.Column<int>(nullable: false),
                    LocationId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    InvoiceIdFrom = table.Column<int>(nullable: false),
                    InvoiceIdTo = table.Column<int>(nullable: false),
                    ReturnInvoiceIdFrom = table.Column<int>(nullable: false),
                    ReturnInvoiceIdTo = table.Column<int>(nullable: false),
                    NetAmount = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    ReturnNetAmount = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    NoteId = table.Column<int>(nullable: false),
                    HeaderGuidId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    EditedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    EditedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvPOSZread", x => new { x.TenantId, x.ZreadId });
                    table.ForeignKey(
                        name: "FK_InvPOSZread_AdminTenant_TenantId",
                        column: x => x.TenantId,
                        principalTable: "AdminTenant",
                        principalColumn: "TenantId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvPOSZread_AdminWFMaster_WorkFlowId",
                        column: x => x.WorkFlowId,
                        principalTable: "AdminWFMaster",
                        principalColumn: "WorkFlowId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvPOSZread_InvLocation_TenantId_LocationId",
                        columns: x => new { x.TenantId, x.LocationId },
                        principalTable: "InvLocation",
                        principalColumns: new[] { "TenantId", "LocationId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvPOSZread_InvPOSTerminal_TenantId_TerminalId",
                        columns: x => new { x.TenantId, x.TerminalId },
                        principalTable: "InvPOSTerminal",
                        principalColumns: new[] { "TenantId", "TerminalId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvPOSZread_AdminUser_TenantId_UserId",
                        columns: x => new { x.TenantId, x.UserId },
                        principalTable: "AdminUser",
                        principalColumns: new[] { "TenantId", "UserId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvPOSZread_AdminWFDocument_TenantId_WorkFlowId_DocumentId",
                        columns: x => new { x.TenantId, x.WorkFlowId, x.DocumentId },
                        principalTable: "AdminWFDocument",
                        principalColumns: new[] { "TenantId", "WorkFlowId", "DocumentId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AdminWFProcess",
                columns: table => new
                {
                    TenantId = table.Column<int>(nullable: false),
                    StepId = table.Column<int>(nullable: false),
                    TransactionId = table.Column<int>(nullable: false),
                    StepStatusId = table.Column<int>(nullable: false),
                    TransStatusId = table.Column<int>(nullable: false),
                    HeaderGuidId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    EditedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    EditedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminWFProcess", x => new { x.TenantId, x.StepId, x.TransactionId });
                    table.ForeignKey(
                        name: "FK_AdminWFProcess_AdminWFStepStatus_StepStatusId",
                        column: x => x.StepStatusId,
                        principalTable: "AdminWFStepStatus",
                        principalColumn: "StepStatusId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AdminWFProcess_AdminTenant_TenantId",
                        column: x => x.TenantId,
                        principalTable: "AdminTenant",
                        principalColumn: "TenantId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdminWFProcess_AdminWFStep_TenantId_StepId",
                        columns: x => new { x.TenantId, x.StepId },
                        principalTable: "AdminWFStep",
                        principalColumns: new[] { "TenantId", "StepId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AdminWfStepAction",
                columns: table => new
                {
                    TenantId = table.Column<int>(nullable: false),
                    StepId = table.Column<int>(nullable: false),
                    ActionId = table.Column<int>(nullable: false),
                    ClassName = table.Column<string>(nullable: false),
                    FunctionName = table.Column<string>(nullable: false),
                    OrderId = table.Column<int>(nullable: false),
                    IsDisabled = table.Column<byte>(nullable: false),
                    IsTransPosted = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminWfStepAction", x => new { x.TenantId, x.StepId, x.ActionId });
                    table.ForeignKey(
                        name: "FK_AdminWfStepAction_AdminTenant_TenantId",
                        column: x => x.TenantId,
                        principalTable: "AdminTenant",
                        principalColumn: "TenantId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdminWfStepAction_AdminWFStep_TenantId_StepId",
                        columns: x => new { x.TenantId, x.StepId },
                        principalTable: "AdminWFStep",
                        principalColumns: new[] { "TenantId", "StepId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InvPOSSalesHeader",
                columns: table => new
                {
                    TenantId = table.Column<int>(nullable: false),
                    InvoiceId = table.Column<int>(nullable: false),
                    WorkFlowId = table.Column<int>(nullable: false),
                    DocumentId = table.Column<int>(nullable: false),
                    TransStatusId = table.Column<int>(nullable: false),
                    InvPOSSalesTypeId = table.Column<int>(nullable: false),
                    InvoiceCode = table.Column<string>(nullable: false),
                    InvoiceDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    TerminalId = table.Column<int>(nullable: false),
                    LocationId = table.Column<int>(nullable: false),
                    CustId = table.Column<int>(nullable: true),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    NetAmount = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    NoteId = table.Column<int>(nullable: false),
                    HeaderGuidId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    EditedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    EditedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvPOSSalesHeader", x => new { x.TenantId, x.InvoiceId });
                    table.ForeignKey(
                        name: "FK_InvPOSSalesHeader_InvPOSSalesType_InvPOSSalesTypeId",
                        column: x => x.InvPOSSalesTypeId,
                        principalTable: "InvPOSSalesType",
                        principalColumn: "InvPOSSalesTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvPOSSalesHeader_AdminTenant_TenantId",
                        column: x => x.TenantId,
                        principalTable: "AdminTenant",
                        principalColumn: "TenantId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvPOSSalesHeader_AdminWFMaster_WorkFlowId",
                        column: x => x.WorkFlowId,
                        principalTable: "AdminWFMaster",
                        principalColumn: "WorkFlowId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvPOSSalesHeader_InvCustomer_TenantId_CustId",
                        columns: x => new { x.TenantId, x.CustId },
                        principalTable: "InvCustomer",
                        principalColumns: new[] { "TenantId", "CustId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvPOSSalesHeader_InvLocation_TenantId_LocationId",
                        columns: x => new { x.TenantId, x.LocationId },
                        principalTable: "InvLocation",
                        principalColumns: new[] { "TenantId", "LocationId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvPOSSalesHeader_InvPOSTerminal_TenantId_TerminalId",
                        columns: x => new { x.TenantId, x.TerminalId },
                        principalTable: "InvPOSTerminal",
                        principalColumns: new[] { "TenantId", "TerminalId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvPOSSalesHeader_AdminWFDocument_TenantId_WorkFlowId_DocumentId",
                        columns: x => new { x.TenantId, x.WorkFlowId, x.DocumentId },
                        principalTable: "AdminWFDocument",
                        principalColumns: new[] { "TenantId", "WorkFlowId", "DocumentId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InvItemUnitBarcode",
                columns: table => new
                {
                    TenantId = table.Column<int>(nullable: false),
                    Barcode = table.Column<string>(type: "nchar(30)", nullable: false),
                    ItemId = table.Column<int>(nullable: false),
                    UnitId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    EditedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    EditedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvItemUnitBarcode", x => new { x.TenantId, x.Barcode });
                    table.ForeignKey(
                        name: "FK_InvItemUnitBarcode_AdminTenant_TenantId",
                        column: x => x.TenantId,
                        principalTable: "AdminTenant",
                        principalColumn: "TenantId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvItemUnitBarcode_InvItemUnit_TenantId_ItemId_UnitId",
                        columns: x => new { x.TenantId, x.ItemId, x.UnitId },
                        principalTable: "InvItemUnit",
                        principalColumns: new[] { "TenantId", "ItemId", "UnitId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InvItemUnitMatrix",
                columns: table => new
                {
                    TenantId = table.Column<int>(nullable: false),
                    ItemId = table.Column<int>(nullable: false),
                    UnitIdFrom = table.Column<int>(nullable: false),
                    UnitIdTo = table.Column<int>(nullable: false),
                    Factor = table.Column<decimal>(type: "decimal(18,6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvItemUnitMatrix", x => new { x.TenantId, x.ItemId, x.UnitIdFrom, x.UnitIdTo });
                    table.ForeignKey(
                        name: "FK_InvItemUnitMatrix_AdminTenant_TenantId",
                        column: x => x.TenantId,
                        principalTable: "AdminTenant",
                        principalColumn: "TenantId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvItemUnitMatrix_InvItemUnit_TenantId_ItemId_UnitIdFrom",
                        columns: x => new { x.TenantId, x.ItemId, x.UnitIdFrom },
                        principalTable: "InvItemUnit",
                        principalColumns: new[] { "TenantId", "ItemId", "UnitId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvItemUnitMatrix_InvItemUnit_TenantId_ItemId_UnitIdTo",
                        columns: x => new { x.TenantId, x.ItemId, x.UnitIdTo },
                        principalTable: "InvItemUnit",
                        principalColumns: new[] { "TenantId", "ItemId", "UnitId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InvPriceDetails",
                columns: table => new
                {
                    TenantId = table.Column<int>(nullable: false),
                    PriceListId = table.Column<int>(nullable: false),
                    ItemId = table.Column<int>(nullable: false),
                    UnitId = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvPriceDetails", x => new { x.TenantId, x.PriceListId, x.ItemId, x.UnitId });
                    table.ForeignKey(
                        name: "FK_InvPriceDetails_AdminTenant_TenantId",
                        column: x => x.TenantId,
                        principalTable: "AdminTenant",
                        principalColumn: "TenantId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvPriceDetails_InvPriceHeader_TenantId_PriceListId",
                        columns: x => new { x.TenantId, x.PriceListId },
                        principalTable: "InvPriceHeader",
                        principalColumns: new[] { "TenantId", "PriceListId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvPriceDetails_InvItemUnit_TenantId_ItemId_UnitId",
                        columns: x => new { x.TenantId, x.ItemId, x.UnitId },
                        principalTable: "InvItemUnit",
                        principalColumns: new[] { "TenantId", "ItemId", "UnitId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InvPOSZreadDetails",
                columns: table => new
                {
                    TenantId = table.Column<int>(nullable: false),
                    ZreadId = table.Column<int>(nullable: false),
                    PaymentMethodId = table.Column<int>(nullable: false),
                    NetAmount = table.Column<decimal>(type: "decimal(18,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvPOSZreadDetails", x => new { x.TenantId, x.ZreadId, x.PaymentMethodId });
                    table.ForeignKey(
                        name: "FK_InvPOSZreadDetails_AdminTenant_TenantId",
                        column: x => x.TenantId,
                        principalTable: "AdminTenant",
                        principalColumn: "TenantId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvPOSZreadDetails_InvPOSSalesPaymentMethod_TenantId_PaymentMethodId",
                        columns: x => new { x.TenantId, x.PaymentMethodId },
                        principalTable: "InvPOSSalesPaymentMethod",
                        principalColumns: new[] { "TenantId", "PaymentMethodId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvPOSZreadDetails_InvPOSZread_TenantId_ZreadId",
                        columns: x => new { x.TenantId, x.ZreadId },
                        principalTable: "InvPOSZread",
                        principalColumns: new[] { "TenantId", "ZreadId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InvPOSReturnHeader",
                columns: table => new
                {
                    TenantId = table.Column<int>(nullable: false),
                    ReturnInvoiceId = table.Column<int>(nullable: false),
                    POSReturnTypeId = table.Column<int>(nullable: false),
                    WorkFlowId = table.Column<int>(nullable: false),
                    DocumentId = table.Column<int>(nullable: false),
                    TransStatusId = table.Column<int>(nullable: false),
                    ReturnInvoiceCode = table.Column<string>(nullable: false),
                    ReturnInvoiceDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    InvoiceIdRefernce = table.Column<int>(nullable: false),
                    TerminalId = table.Column<int>(nullable: false),
                    LocationId = table.Column<int>(nullable: false),
                    CustId = table.Column<int>(nullable: true),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    NetAmount = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    NoteId = table.Column<int>(nullable: false),
                    HeaderGuidId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    EditedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    EditedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvPOSReturnHeader", x => new { x.TenantId, x.ReturnInvoiceId });
                    table.ForeignKey(
                        name: "FK_InvPOSReturnHeader_InvPOSReturnType_POSReturnTypeId",
                        column: x => x.POSReturnTypeId,
                        principalTable: "InvPOSReturnType",
                        principalColumn: "InvPOSReturnTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvPOSReturnHeader_AdminTenant_TenantId",
                        column: x => x.TenantId,
                        principalTable: "AdminTenant",
                        principalColumn: "TenantId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvPOSReturnHeader_AdminWFMaster_WorkFlowId",
                        column: x => x.WorkFlowId,
                        principalTable: "AdminWFMaster",
                        principalColumn: "WorkFlowId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvPOSReturnHeader_InvCustomer_TenantId_CustId",
                        columns: x => new { x.TenantId, x.CustId },
                        principalTable: "InvCustomer",
                        principalColumns: new[] { "TenantId", "CustId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvPOSReturnHeader_InvPOSSalesHeader_TenantId_InvoiceIdRefernce",
                        columns: x => new { x.TenantId, x.InvoiceIdRefernce },
                        principalTable: "InvPOSSalesHeader",
                        principalColumns: new[] { "TenantId", "InvoiceId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvPOSReturnHeader_InvLocation_TenantId_LocationId",
                        columns: x => new { x.TenantId, x.LocationId },
                        principalTable: "InvLocation",
                        principalColumns: new[] { "TenantId", "LocationId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvPOSReturnHeader_InvPOSTerminal_TenantId_TerminalId",
                        columns: x => new { x.TenantId, x.TerminalId },
                        principalTable: "InvPOSTerminal",
                        principalColumns: new[] { "TenantId", "TerminalId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvPOSReturnHeader_AdminWFDocument_TenantId_WorkFlowId_DocumentId",
                        columns: x => new { x.TenantId, x.WorkFlowId, x.DocumentId },
                        principalTable: "AdminWFDocument",
                        principalColumns: new[] { "TenantId", "WorkFlowId", "DocumentId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InvPOSSalesDetails",
                columns: table => new
                {
                    TenantId = table.Column<int>(nullable: false),
                    InvoiceId = table.Column<int>(nullable: false),
                    DetailsId = table.Column<int>(nullable: false),
                    ItemId = table.Column<int>(nullable: false),
                    UnitId = table.Column<int>(nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    NetAmount = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    DetailsGuidId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvPOSSalesDetails", x => new { x.TenantId, x.InvoiceId, x.DetailsId });
                    table.ForeignKey(
                        name: "FK_InvPOSSalesDetails_AdminTenant_TenantId",
                        column: x => x.TenantId,
                        principalTable: "AdminTenant",
                        principalColumn: "TenantId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvPOSSalesDetails_InvPOSSalesHeader_TenantId_InvoiceId",
                        columns: x => new { x.TenantId, x.InvoiceId },
                        principalTable: "InvPOSSalesHeader",
                        principalColumns: new[] { "TenantId", "InvoiceId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvPOSSalesDetails_InvItemUnit_TenantId_ItemId_UnitId",
                        columns: x => new { x.TenantId, x.ItemId, x.UnitId },
                        principalTable: "InvItemUnit",
                        principalColumns: new[] { "TenantId", "ItemId", "UnitId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InvPOSReturnDetails",
                columns: table => new
                {
                    TenantId = table.Column<int>(nullable: false),
                    ReturnInvoiceId = table.Column<int>(nullable: false),
                    DetailsId = table.Column<int>(nullable: false),
                    ItemId = table.Column<int>(nullable: false),
                    UnitId = table.Column<int>(nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    NetAmount = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    DetailsGuidId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvPOSReturnDetails", x => new { x.TenantId, x.ReturnInvoiceId, x.DetailsId });
                    table.ForeignKey(
                        name: "FK_InvPOSReturnDetails_AdminTenant_TenantId",
                        column: x => x.TenantId,
                        principalTable: "AdminTenant",
                        principalColumn: "TenantId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvPOSReturnDetails_InvPOSReturnHeader_TenantId_ReturnInvoiceId",
                        columns: x => new { x.TenantId, x.ReturnInvoiceId },
                        principalTable: "InvPOSReturnHeader",
                        principalColumns: new[] { "TenantId", "ReturnInvoiceId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvPOSReturnDetails_InvItemUnit_TenantId_ItemId_UnitId",
                        columns: x => new { x.TenantId, x.ItemId, x.UnitId },
                        principalTable: "InvItemUnit",
                        principalColumns: new[] { "TenantId", "ItemId", "UnitId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InvPOSSalesPayment",
                columns: table => new
                {
                    TenantId = table.Column<int>(nullable: false),
                    InvoiceId = table.Column<int>(nullable: false),
                    PaymentMethodId = table.Column<int>(nullable: false),
                    ReturnVoucherRetId = table.Column<int>(nullable: true),
                    PaymentAmount = table.Column<decimal>(type: "decimal(18,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvPOSSalesPayment", x => new { x.TenantId, x.InvoiceId, x.PaymentMethodId });
                    table.ForeignKey(
                        name: "FK_InvPOSSalesPayment_AdminTenant_TenantId",
                        column: x => x.TenantId,
                        principalTable: "AdminTenant",
                        principalColumn: "TenantId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvPOSSalesPayment_InvPOSSalesHeader_TenantId_InvoiceId",
                        columns: x => new { x.TenantId, x.InvoiceId },
                        principalTable: "InvPOSSalesHeader",
                        principalColumns: new[] { "TenantId", "InvoiceId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvPOSSalesPayment_InvPOSSalesPaymentMethod_TenantId_PaymentMethodId",
                        columns: x => new { x.TenantId, x.PaymentMethodId },
                        principalTable: "InvPOSSalesPaymentMethod",
                        principalColumns: new[] { "TenantId", "PaymentMethodId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvPOSSalesPayment_InvPOSReturnHeader_TenantId_ReturnVoucherRetId",
                        columns: x => new { x.TenantId, x.ReturnVoucherRetId },
                        principalTable: "InvPOSReturnHeader",
                        principalColumns: new[] { "TenantId", "ReturnInvoiceId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AdminObject",
                columns: new[] { "ObjectId", "IsFixedList", "ObjectDescription" },
                values: new object[,]
                {
                    { 10000001, (byte)1, "Package name" },
                    { 10000002, (byte)1, "Package description" },
                    { 10000003, (byte)1, "Module" },
                    { 10000004, (byte)1, "Right" },
                    { 10000005, (byte)1, "Screen level" },
                    { 10000006, (byte)1, "Screen" },
                    { 10000007, (byte)1, "Workflow master" },
                    { 10000008, (byte)1, "Step Status" },
                    { 10000009, (byte)1, "Trans Status" },
                    { 10100001, (byte)1, "Return type" },
                    { 10100002, (byte)1, "Sales type" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdminChart_TenantId_ChartLevelId",
                table: "AdminChart",
                columns: new[] { "TenantId", "ChartLevelId" });

            migrationBuilder.CreateIndex(
                name: "IX_AdminChart_TenantId_ChartParentId",
                table: "AdminChart",
                columns: new[] { "TenantId", "ChartParentId" });

            migrationBuilder.CreateIndex(
                name: "IX_AdminCoding_WorkFlowId",
                table: "AdminCoding",
                column: "WorkFlowId");

            migrationBuilder.CreateIndex(
                name: "IX_AdminCoding_TenantId_WorkFlowId_DocumentId",
                table: "AdminCoding",
                columns: new[] { "TenantId", "WorkFlowId", "DocumentId" });

            migrationBuilder.CreateIndex(
                name: "IX_AdminModuleScreen_ScreenId",
                table: "AdminModuleScreen",
                column: "ScreenId");

            migrationBuilder.CreateIndex(
                name: "IX_AdminObjectLanguage_LanguageId",
                table: "AdminObjectLanguage",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_AdminObjectLanguage_ObjectId",
                table: "AdminObjectLanguage",
                column: "ObjectId");

            migrationBuilder.CreateIndex(
                name: "IX_AdminPackageModule_ModuleId",
                table: "AdminPackageModule",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_AdminProvince_TenantId_CountryId",
                table: "AdminProvince",
                columns: new[] { "TenantId", "CountryId" });

            migrationBuilder.CreateIndex(
                name: "IX_AdminScreen_RightId",
                table: "AdminScreen",
                column: "RightId");

            migrationBuilder.CreateIndex(
                name: "IX_AdminScreen_ScreenLevelId",
                table: "AdminScreen",
                column: "ScreenLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_AdminScreen_ScreenParentId",
                table: "AdminScreen",
                column: "ScreenParentId");

            migrationBuilder.CreateIndex(
                name: "IX_AdminScreenLanguage_LanguageId",
                table: "AdminScreenLanguage",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_AdminTenantLanguage_LanguageId",
                table: "AdminTenantLanguage",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_AdminTenantPackage_PackageId",
                table: "AdminTenantPackage",
                column: "PackageId");

            migrationBuilder.CreateIndex(
                name: "IX_AdminTown_TenantId_ProvinceId",
                table: "AdminTown",
                columns: new[] { "TenantId", "ProvinceId" });

            migrationBuilder.CreateIndex(
                name: "IX_AdminUser_TenantId_ChartId",
                table: "AdminUser",
                columns: new[] { "TenantId", "ChartId" });

            migrationBuilder.CreateIndex(
                name: "IX_AdminWFDocument_WorkFlowId",
                table: "AdminWFDocument",
                column: "WorkFlowId");

            migrationBuilder.CreateIndex(
                name: "IX_AdminWFMaster_ScreenId",
                table: "AdminWFMaster",
                column: "ScreenId");

            migrationBuilder.CreateIndex(
                name: "IX_AdminWFProcess_StepStatusId",
                table: "AdminWFProcess",
                column: "StepStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_AdminWFStep_WorkFlowId",
                table: "AdminWFStep",
                column: "WorkFlowId");

            migrationBuilder.CreateIndex(
                name: "IX_AdminWFStep_TenantId_ActorId",
                table: "AdminWFStep",
                columns: new[] { "TenantId", "ActorId" });

            migrationBuilder.CreateIndex(
                name: "IX_AdminWFStep_TenantId_NextStepId",
                table: "AdminWFStep",
                columns: new[] { "TenantId", "NextStepId" });

            migrationBuilder.CreateIndex(
                name: "IX_AdminWFStep_TenantId_WorkFlowId_DocumentId",
                table: "AdminWFStep",
                columns: new[] { "TenantId", "WorkFlowId", "DocumentId" });

            migrationBuilder.CreateIndex(
                name: "IX_AdminWFTransList_TransStatusId",
                table: "AdminWFTransList",
                column: "TransStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_AdminWFTransList_WorkFlowId",
                table: "AdminWFTransList",
                column: "WorkFlowId");

            migrationBuilder.CreateIndex(
                name: "IX_AdminWFTransList_TenantId_WorkFlowId_DocumentId",
                table: "AdminWFTransList",
                columns: new[] { "TenantId", "WorkFlowId", "DocumentId" });

            migrationBuilder.CreateIndex(
                name: "IX_InvCustomer_TenantId_ProvinceId",
                table: "InvCustomer",
                columns: new[] { "TenantId", "ProvinceId" });

            migrationBuilder.CreateIndex(
                name: "IX_InvCustomer_TenantId_TownId",
                table: "InvCustomer",
                columns: new[] { "TenantId", "TownId" });

            migrationBuilder.CreateIndex(
                name: "IX_InvItemCategory_TenantId_CatLevelId",
                table: "InvItemCategory",
                columns: new[] { "TenantId", "CatLevelId" });

            migrationBuilder.CreateIndex(
                name: "IX_InvItemCategory_TenantId_CatParentId",
                table: "InvItemCategory",
                columns: new[] { "TenantId", "CatParentId" });

            migrationBuilder.CreateIndex(
                name: "IX_InvItemMaster_TenantId_CatId",
                table: "InvItemMaster",
                columns: new[] { "TenantId", "CatId" });

            migrationBuilder.CreateIndex(
                name: "IX_InvItemUnit_TenantId_UnitId",
                table: "InvItemUnit",
                columns: new[] { "TenantId", "UnitId" });

            migrationBuilder.CreateIndex(
                name: "IX_InvItemUnitBarcode_TenantId_ItemId_UnitId",
                table: "InvItemUnitBarcode",
                columns: new[] { "TenantId", "ItemId", "UnitId" });

            migrationBuilder.CreateIndex(
                name: "IX_InvItemUnitMatrix_TenantId_ItemId_UnitIdTo",
                table: "InvItemUnitMatrix",
                columns: new[] { "TenantId", "ItemId", "UnitIdTo" });

            migrationBuilder.CreateIndex(
                name: "IX_InvLocation_TenantId_LocationLevelId",
                table: "InvLocation",
                columns: new[] { "TenantId", "LocationLevelId" });

            migrationBuilder.CreateIndex(
                name: "IX_InvLocation_TenantId_LocationParentId",
                table: "InvLocation",
                columns: new[] { "TenantId", "LocationParentId" });

            migrationBuilder.CreateIndex(
                name: "IX_InvLocation_TenantId_PriceListId",
                table: "InvLocation",
                columns: new[] { "TenantId", "PriceListId" });

            migrationBuilder.CreateIndex(
                name: "IX_InvPOSReturnDetails_TenantId_ItemId_UnitId",
                table: "InvPOSReturnDetails",
                columns: new[] { "TenantId", "ItemId", "UnitId" });

            migrationBuilder.CreateIndex(
                name: "IX_InvPOSReturnHeader_POSReturnTypeId",
                table: "InvPOSReturnHeader",
                column: "POSReturnTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_InvPOSReturnHeader_WorkFlowId",
                table: "InvPOSReturnHeader",
                column: "WorkFlowId");

            migrationBuilder.CreateIndex(
                name: "IX_InvPOSReturnHeader_TenantId_CustId",
                table: "InvPOSReturnHeader",
                columns: new[] { "TenantId", "CustId" });

            migrationBuilder.CreateIndex(
                name: "IX_InvPOSReturnHeader_TenantId_InvoiceIdRefernce",
                table: "InvPOSReturnHeader",
                columns: new[] { "TenantId", "InvoiceIdRefernce" });

            migrationBuilder.CreateIndex(
                name: "IX_InvPOSReturnHeader_TenantId_LocationId",
                table: "InvPOSReturnHeader",
                columns: new[] { "TenantId", "LocationId" });

            migrationBuilder.CreateIndex(
                name: "IX_InvPOSReturnHeader_TenantId_TerminalId",
                table: "InvPOSReturnHeader",
                columns: new[] { "TenantId", "TerminalId" });

            migrationBuilder.CreateIndex(
                name: "IX_InvPOSReturnHeader_TenantId_WorkFlowId_DocumentId",
                table: "InvPOSReturnHeader",
                columns: new[] { "TenantId", "WorkFlowId", "DocumentId" });

            migrationBuilder.CreateIndex(
                name: "IX_InvPOSSalesDetails_TenantId_ItemId_UnitId",
                table: "InvPOSSalesDetails",
                columns: new[] { "TenantId", "ItemId", "UnitId" });

            migrationBuilder.CreateIndex(
                name: "IX_InvPOSSalesHeader_InvPOSSalesTypeId",
                table: "InvPOSSalesHeader",
                column: "InvPOSSalesTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_InvPOSSalesHeader_WorkFlowId",
                table: "InvPOSSalesHeader",
                column: "WorkFlowId");

            migrationBuilder.CreateIndex(
                name: "IX_InvPOSSalesHeader_TenantId_CustId",
                table: "InvPOSSalesHeader",
                columns: new[] { "TenantId", "CustId" });

            migrationBuilder.CreateIndex(
                name: "IX_InvPOSSalesHeader_TenantId_LocationId",
                table: "InvPOSSalesHeader",
                columns: new[] { "TenantId", "LocationId" });

            migrationBuilder.CreateIndex(
                name: "IX_InvPOSSalesHeader_TenantId_TerminalId",
                table: "InvPOSSalesHeader",
                columns: new[] { "TenantId", "TerminalId" });

            migrationBuilder.CreateIndex(
                name: "IX_InvPOSSalesHeader_TenantId_WorkFlowId_DocumentId",
                table: "InvPOSSalesHeader",
                columns: new[] { "TenantId", "WorkFlowId", "DocumentId" });

            migrationBuilder.CreateIndex(
                name: "IX_InvPOSSalesPayment_TenantId_PaymentMethodId",
                table: "InvPOSSalesPayment",
                columns: new[] { "TenantId", "PaymentMethodId" });

            migrationBuilder.CreateIndex(
                name: "IX_InvPOSSalesPayment_TenantId_ReturnVoucherRetId",
                table: "InvPOSSalesPayment",
                columns: new[] { "TenantId", "ReturnVoucherRetId" });

            migrationBuilder.CreateIndex(
                name: "IX_InvPOSTerminal_TenantId_LocationId",
                table: "InvPOSTerminal",
                columns: new[] { "TenantId", "LocationId" });

            migrationBuilder.CreateIndex(
                name: "IX_InvPOSZread_WorkFlowId",
                table: "InvPOSZread",
                column: "WorkFlowId");

            migrationBuilder.CreateIndex(
                name: "IX_InvPOSZread_TenantId_LocationId",
                table: "InvPOSZread",
                columns: new[] { "TenantId", "LocationId" });

            migrationBuilder.CreateIndex(
                name: "IX_InvPOSZread_TenantId_TerminalId",
                table: "InvPOSZread",
                columns: new[] { "TenantId", "TerminalId" });

            migrationBuilder.CreateIndex(
                name: "IX_InvPOSZread_TenantId_UserId",
                table: "InvPOSZread",
                columns: new[] { "TenantId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_InvPOSZread_TenantId_WorkFlowId_DocumentId",
                table: "InvPOSZread",
                columns: new[] { "TenantId", "WorkFlowId", "DocumentId" });

            migrationBuilder.CreateIndex(
                name: "IX_InvPOSZreadDetails_TenantId_PaymentMethodId",
                table: "InvPOSZreadDetails",
                columns: new[] { "TenantId", "PaymentMethodId" });

            migrationBuilder.CreateIndex(
                name: "IX_InvPriceDetails_TenantId_ItemId_UnitId",
                table: "InvPriceDetails",
                columns: new[] { "TenantId", "ItemId", "UnitId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminCoding");

            migrationBuilder.DropTable(
                name: "AdminCurrency");

            migrationBuilder.DropTable(
                name: "AdminModuleScreen");

            migrationBuilder.DropTable(
                name: "AdminNationality");

            migrationBuilder.DropTable(
                name: "AdminNotes");

            migrationBuilder.DropTable(
                name: "AdminObjectLanguage");

            migrationBuilder.DropTable(
                name: "AdminPackageModule");

            migrationBuilder.DropTable(
                name: "AdminScreenLanguage");

            migrationBuilder.DropTable(
                name: "AdminTenantLanguage");

            migrationBuilder.DropTable(
                name: "AdminTenantPackage");

            migrationBuilder.DropTable(
                name: "AdminWFProcess");

            migrationBuilder.DropTable(
                name: "AdminWfStepAction");

            migrationBuilder.DropTable(
                name: "AdminWFTransList");

            migrationBuilder.DropTable(
                name: "InvItemUnitBarcode");

            migrationBuilder.DropTable(
                name: "InvItemUnitMatrix");

            migrationBuilder.DropTable(
                name: "InvPOSReturnDetails");

            migrationBuilder.DropTable(
                name: "InvPOSSalesDetails");

            migrationBuilder.DropTable(
                name: "InvPOSSalesPayment");

            migrationBuilder.DropTable(
                name: "InvPOSZreadDetails");

            migrationBuilder.DropTable(
                name: "InvPriceDetails");

            migrationBuilder.DropTable(
                name: "AdminObject");

            migrationBuilder.DropTable(
                name: "AdminLanguage");

            migrationBuilder.DropTable(
                name: "AdminPackage");

            migrationBuilder.DropTable(
                name: "AdminWFStepStatus");

            migrationBuilder.DropTable(
                name: "AdminWFStep");

            migrationBuilder.DropTable(
                name: "AdminWFTransStatus");

            migrationBuilder.DropTable(
                name: "InvPOSReturnHeader");

            migrationBuilder.DropTable(
                name: "InvPOSSalesPaymentMethod");

            migrationBuilder.DropTable(
                name: "InvPOSZread");

            migrationBuilder.DropTable(
                name: "InvItemUnit");

            migrationBuilder.DropTable(
                name: "AdminActor");

            migrationBuilder.DropTable(
                name: "InvPOSReturnType");

            migrationBuilder.DropTable(
                name: "InvPOSSalesHeader");

            migrationBuilder.DropTable(
                name: "AdminUser");

            migrationBuilder.DropTable(
                name: "InvItemMaster");

            migrationBuilder.DropTable(
                name: "InvItemUnitOfMeasure");

            migrationBuilder.DropTable(
                name: "InvPOSSalesType");

            migrationBuilder.DropTable(
                name: "InvCustomer");

            migrationBuilder.DropTable(
                name: "InvPOSTerminal");

            migrationBuilder.DropTable(
                name: "AdminWFDocument");

            migrationBuilder.DropTable(
                name: "AdminChart");

            migrationBuilder.DropTable(
                name: "InvItemCategory");

            migrationBuilder.DropTable(
                name: "AdminTown");

            migrationBuilder.DropTable(
                name: "InvLocation");

            migrationBuilder.DropTable(
                name: "AdminWFMaster");

            migrationBuilder.DropTable(
                name: "AdminChartLevel");

            migrationBuilder.DropTable(
                name: "InvItemCategoryLevel");

            migrationBuilder.DropTable(
                name: "AdminProvince");

            migrationBuilder.DropTable(
                name: "InvLocationLevel");

            migrationBuilder.DropTable(
                name: "InvPriceHeader");

            migrationBuilder.DropTable(
                name: "AdminScreen");

            migrationBuilder.DropTable(
                name: "AdminModule");

            migrationBuilder.DropTable(
                name: "AdminCountry");

            migrationBuilder.DropTable(
                name: "AdminRight");

            migrationBuilder.DropTable(
                name: "AdminScreenLevel");

            migrationBuilder.DropTable(
                name: "AdminTenant");
        }
    }
}
