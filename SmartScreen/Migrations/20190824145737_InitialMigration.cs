using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Oracle.EntityFrameworkCore.Metadata;

namespace SmartScreen.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerAccounts",
                columns: table => new
                {
                    CustomerAccountNumber = table.Column<int>(nullable: false)
                        .Annotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerAccounts", x => x.CustomerAccountNumber);
                });

            migrationBuilder.CreateTable(
                name: "ECONOMIC_SUB_SECTOR_CODE",
                columns: table => new
                {
                    economic_sub_sector_bnr = table.Column<int>(nullable: false)
                        .Annotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn),
                    economic_sub_sector_bnr_desc = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ECONOMIC_SUB_SECTOR_CODE", x => x.economic_sub_sector_bnr);
                });

            migrationBuilder.CreateTable(
                name: "ECONOMIC_SUB_SECTOR_CODE_ISIC",
                columns: table => new
                {
                    economic_sub_sector_code_isic = table.Column<int>(nullable: false)
                        .Annotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn),
                    economic_sub_sector_code_desc = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ECONOMIC_SUB_SECTOR_CODE_ISIC", x => x.economic_sub_sector_code_isic);
                });

            migrationBuilder.CreateTable(
                name: "EDUCATION",
                columns: table => new
                {
                    code_edu = table.Column<string>(nullable: false),
                    description_edu = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EDUCATION", x => x.code_edu);
                });

            migrationBuilder.CreateTable(
                name: "NAICS_CODE",
                columns: table => new
                {
                    naics_codes = table.Column<string>(nullable: false),
                    naics_description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NAICS_CODE", x => x.naics_codes);
                });

            migrationBuilder.CreateTable(
                name: "RELATED_PARTY",
                columns: table => new
                {
                    related_party = table.Column<string>(nullable: false),
                    related_party_description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RELATED_PARTY", x => x.related_party);
                });

            migrationBuilder.CreateTable(
                name: "RESIDENCE_TYPE",
                columns: table => new
                {
                    code = table.Column<string>(nullable: false),
                    description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RESIDENCE_TYPE", x => x.code);
                });

            migrationBuilder.CreateTable(
                name: "VILLAGE_LIST",
                columns: table => new
                {
                    village_list = table.Column<string>(nullable: false),
                    vilage_list_description = table.Column<string>(nullable: false),
                    cell_list = table.Column<string>(nullable: false),
                    cell_list_description = table.Column<string>(nullable: false),
                    sector_list = table.Column<string>(nullable: false),
                    sector_list_description = table.Column<string>(nullable: false),
                    district_list = table.Column<string>(nullable: false),
                    district_list_description = table.Column<string>(nullable: false),
                    province_list = table.Column<string>(nullable: false),
                    province_list_description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VILLAGE_LIST", x => x.village_list);
                });

            migrationBuilder.CreateTable(
                name: "VISION_SBU",
                columns: table => new
                {
                    vision_sbu = table.Column<string>(nullable: false),
                    description = table.Column<string>(nullable: false),
                    definition = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VISION_SBU", x => x.vision_sbu);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BNR_CUSTOMER",
                columns: table => new
                {
                    cust_no = table.Column<string>(nullable: false),
                    Cust_name = table.Column<string>(nullable: false),
                    vision_sbu = table.Column<string>(nullable: false),
                    village = table.Column<string>(nullable: false),
                    residence_type = table.Column<string>(nullable: false),
                    education = table.Column<string>(nullable: false),
                    naics_code = table.Column<string>(nullable: false),
                    sub_sector_code = table.Column<int>(nullable: false),
                    sub_sector_code_isic = table.Column<int>(name: " sub_sector_code_isic", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BNR_CUSTOMER", x => x.cust_no);
                    table.ForeignKey(
                        name: "FK_BNR_CUSTOMER_ECONOMIC_SUB_SECTOR_CODE_ISIC_ sub_sector_code_isic",
                        column: x => x.sub_sector_code_isic,
                        principalTable: "ECONOMIC_SUB_SECTOR_CODE_ISIC",
                        principalColumn: "economic_sub_sector_code_isic",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BNR_CUSTOMER_ECONOMIC_SUB_SECTOR_CODE_sub_sector_code",
                        column: x => x.sub_sector_code,
                        principalTable: "ECONOMIC_SUB_SECTOR_CODE",
                        principalColumn: "economic_sub_sector_bnr",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BNR_CUSTOMER_EDUCATION_education",
                        column: x => x.education,
                        principalTable: "EDUCATION",
                        principalColumn: "code_edu",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BNR_CUSTOMER_NAICS_CODE_naics_code",
                        column: x => x.naics_code,
                        principalTable: "NAICS_CODE",
                        principalColumn: "naics_codes",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BNR_CUSTOMER_RESIDENCE_TYPE_residence_type",
                        column: x => x.residence_type,
                        principalTable: "RESIDENCE_TYPE",
                        principalColumn: "code",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BNR_CUSTOMER_VILLAGE_LIST_village",
                        column: x => x.village,
                        principalTable: "VILLAGE_LIST",
                        principalColumn: "village_list",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BNR_CUSTOMER_VISION_SBU_vision_sbu",
                        column: x => x.vision_sbu,
                        principalTable: "VISION_SBU",
                        principalColumn: "vision_sbu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BNR_CUSTOMER_ sub_sector_code_isic",
                table: "BNR_CUSTOMER",
                column: " sub_sector_code_isic");

            migrationBuilder.CreateIndex(
                name: "IX_BNR_CUSTOMER_sub_sector_code",
                table: "BNR_CUSTOMER",
                column: "sub_sector_code");

            migrationBuilder.CreateIndex(
                name: "IX_BNR_CUSTOMER_education",
                table: "BNR_CUSTOMER",
                column: "education");

            migrationBuilder.CreateIndex(
                name: "IX_BNR_CUSTOMER_naics_code",
                table: "BNR_CUSTOMER",
                column: "naics_code");

            migrationBuilder.CreateIndex(
                name: "IX_BNR_CUSTOMER_residence_type",
                table: "BNR_CUSTOMER",
                column: "residence_type");

            migrationBuilder.CreateIndex(
                name: "IX_BNR_CUSTOMER_village",
                table: "BNR_CUSTOMER",
                column: "village");

            migrationBuilder.CreateIndex(
                name: "IX_BNR_CUSTOMER_vision_sbu",
                table: "BNR_CUSTOMER",
                column: "vision_sbu");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BNR_CUSTOMER");

            migrationBuilder.DropTable(
                name: "CustomerAccounts");

            migrationBuilder.DropTable(
                name: "RELATED_PARTY");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ECONOMIC_SUB_SECTOR_CODE_ISIC");

            migrationBuilder.DropTable(
                name: "ECONOMIC_SUB_SECTOR_CODE");

            migrationBuilder.DropTable(
                name: "EDUCATION");

            migrationBuilder.DropTable(
                name: "NAICS_CODE");

            migrationBuilder.DropTable(
                name: "RESIDENCE_TYPE");

            migrationBuilder.DropTable(
                name: "VILLAGE_LIST");

            migrationBuilder.DropTable(
                name: "VISION_SBU");
        }
    }
}
