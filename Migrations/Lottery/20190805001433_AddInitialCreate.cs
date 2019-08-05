using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SpaBingo.Migrations.Lottery
{
    public partial class AddInitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer_Billing_Queue",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReplicationID = table.Column<Guid>(nullable: false),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedByStaffID = table.Column<int>(nullable: true),
                    FranchiseID = table.Column<int>(nullable: false),
                    QueueTypeID = table.Column<int>(nullable: false),
                    PeriodIntendedDate = table.Column<DateTime>(nullable: true),
                    StartedOn = table.Column<DateTime>(nullable: true),
                    CompletedOn = table.Column<DateTime>(nullable: true),
                    CanceledOn = table.Column<DateTime>(nullable: true),
                    CanceledByStaffID = table.Column<int>(nullable: true),
                    CanceledReason = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer_Billing_Queue", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CustomerBalanceType",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReplicationID = table.Column<Guid>(nullable: false),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedByStaffID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    MaxLimitAmount = table.Column<decimal>(nullable: true),
                    IsDisplayed = table.Column<bool>(nullable: false),
                    Alias = table.Column<string>(nullable: true),
                    DisplayOrder = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerBalanceType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Games_Lottery_Drawings_Group",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    ReplicationID = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games_Lottery_Drawings_Group", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Games_Lottery_GameTypes",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    ReplicationID = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDisplayed = table.Column<bool>(nullable: false),
                    ImageID = table.Column<string>(nullable: true),
                    AllowStraightBets = table.Column<bool>(nullable: false),
                    AllowBoxedBets = table.Column<bool>(nullable: false),
                    DependentOnGameTypeID = table.Column<string>(nullable: true),
                    LotteryType = table.Column<string>(nullable: true),
                    TranslationID = table.Column<int>(nullable: true),
                    IsAffectedByDST = table.Column<bool>(nullable: false),
                    JackpotID = table.Column<short>(nullable: true),
                    InactiveReason = table.Column<string>(nullable: true),
                    GameTypeID = table.Column<int>(nullable: false),
                    Denominations = table.Column<string>(nullable: true),
                    Games_Lottery_LotteryProviderGameType_ID = table.Column<int>(nullable: true),
                    CanAutoPost = table.Column<bool>(nullable: false),
                    AutoPostInactiveReason = table.Column<string>(nullable: true),
                    Games_Lottery_GameTypeGroup_ID = table.Column<int>(nullable: true),
                    PermutationCount = table.Column<int>(nullable: true),
                    ScheduleGroupID = table.Column<long>(nullable: true),
                    DrawingTimeOffsetMinutes = table.Column<int>(nullable: true),
                    Games_Lottery_ExternalLottery_ID = table.Column<int>(nullable: true),
                    ExtraPlayAddedAmount = table.Column<decimal>(nullable: true),
                    LocalDrawingTimezoneID = table.Column<int>(nullable: true),
                    LocalDrawingTimezoneIANA = table.Column<string>(nullable: true),
                    JackpotGroupID = table.Column<short>(nullable: true),
                    Fractions = table.Column<short>(nullable: true),
                    OrderValidDays = table.Column<int>(nullable: true),
                    RequiresUniqueBalls = table.Column<bool>(nullable: false),
                    EstimatedJackpot = table.Column<string>(nullable: true),
                    AllowedBallCountsOnOrder = table.Column<string>(nullable: true),
                    ImageURL = table.Column<string>(nullable: true),
                    Alias = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games_Lottery_GameTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GameType",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    ReplicationID = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedByID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDisplayed = table.Column<bool>(nullable: false),
                    PayoutWindowInDays = table.Column<int>(nullable: false),
                    InactiveReason = table.Column<string>(nullable: true),
                    TranslationID = table.Column<int>(nullable: true),
                    IsAutoPostingEnabled = table.Column<bool>(nullable: false),
                    AutoPostingInactiveReason = table.Column<string>(nullable: true),
                    OrderLineItemLimit = table.Column<int>(nullable: true),
                    AdvancedPlayLimit = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GeneralDomain",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ParentID = table.Column<int>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    GeneralDomain2ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralDomain", x => x.ID);
                    table.ForeignKey(
                        name: "FK_GeneralDomain_GeneralDomain_GeneralDomain2ID",
                        column: x => x.GeneralDomain2ID,
                        principalTable: "GeneralDomain",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Limit",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReplicationID = table.Column<Guid>(nullable: false),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedByStaffID = table.Column<int>(nullable: true),
                    CreatedByCustomerID = table.Column<long>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    LimitCanBeAppliedOn = table.Column<DateTime>(nullable: true),
                    ApplyChangesToLimitID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Limit", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LimitType",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReplicationID = table.Column<Guid>(nullable: false),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedByStaffID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LimitType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Promotion",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    ReplicationID = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    InternalName = table.Column<string>(nullable: true),
                    PromotionName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotion", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Promotions_EventBonusing_EventTypes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReplicationID = table.Column<Guid>(nullable: false),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    InternalName = table.Column<string>(nullable: true),
                    DisplayName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    CanBePercent = table.Column<bool>(nullable: false),
                    IsAllowedMultiple = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotions_EventBonusing_EventTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Staff_Jobs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReplicationID = table.Column<Guid>(nullable: false),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedByStaffID = table.Column<int>(nullable: true),
                    LastChangedOn = table.Column<DateTime>(nullable: true),
                    LastChangedByStaffID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ThirdPartyJob = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff_Jobs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Syndicate_Queue",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReplicationID = table.Column<Guid>(nullable: false),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    Syndicate_PeriodID = table.Column<long>(nullable: false),
                    CustomerAccountID = table.Column<long>(nullable: false),
                    BilledOn = table.Column<DateTime>(nullable: true),
                    TransactionID = table.Column<long>(nullable: true),
                    WasPooled = table.Column<bool>(nullable: false),
                    FailedTransactionID = table.Column<long>(nullable: true),
                    NotifiedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Syndicate_Queue", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TransactionType",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    ReplicationID = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    APIName = table.Column<string>(nullable: true),
                    DCCustomer = table.Column<string>(nullable: true),
                    DCStaff = table.Column<string>(nullable: true),
                    DCThirdParty = table.Column<string>(nullable: true),
                    InternalNotes = table.Column<string>(nullable: true),
                    TranslationID = table.Column<int>(nullable: true),
                    TransactionTypeGroupID = table.Column<int>(nullable: true),
                    IsCorrectable = table.Column<bool>(nullable: false),
                    RequiresFollowUp = table.Column<bool>(nullable: false),
                    CustomerDisplayName = table.Column<string>(nullable: true),
                    IsShownToCustomers = table.Column<bool>(nullable: false),
                    IsShownToStaff = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Franchises",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    ReplicationID = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    IsIncludedInReports = table.Column<bool>(nullable: false),
                    WalletType = table.Column<string>(nullable: true),
                    TimeZone = table.Column<string>(nullable: true),
                    TimeZoneOffset = table.Column<string>(nullable: true),
                    TimeZoneName = table.Column<string>(nullable: true),
                    DefaultLanguage = table.Column<string>(nullable: true),
                    ASPCustomerApplicationID = table.Column<Guid>(nullable: true),
                    Wallet_APIURL = table.Column<string>(nullable: true),
                    Wallet_APIAuthentication = table.Column<string>(nullable: true),
                    Wallet_Currency = table.Column<string>(nullable: true),
                    TicketHeader = table.Column<string>(nullable: true),
                    TicketFooter = table.Column<string>(nullable: true),
                    Denominations = table.Column<string>(nullable: true),
                    AllowFractionalBets = table.Column<bool>(nullable: false),
                    CurrencyCulture = table.Column<string>(nullable: true),
                    TicketLogo = table.Column<string>(nullable: true),
                    DepositWithdrawFranchiseID = table.Column<int>(nullable: true),
                    CanMakeCustomerDeposits = table.Column<bool>(nullable: false),
                    CanMakeCustomerWithdraws = table.Column<bool>(nullable: false),
                    IsSwipeRequired = table.Column<bool>(nullable: false),
                    ATMCardParsingRegex = table.Column<string>(nullable: true),
                    OrderValidDays = table.Column<int>(nullable: true),
                    SystemLimitID = table.Column<int>(nullable: true),
                    SysopOnly = table.Column<bool>(nullable: false),
                    Gaming_UsesCashBalance = table.Column<bool>(nullable: false),
                    Gaming_UsesBonusBalance = table.Column<bool>(nullable: false),
                    Gaming_UsesBonusBalanceBeforeCashBalance = table.Column<bool>(nullable: false),
                    Payouts_DailyPayoutMaximumThreshold = table.Column<decimal>(nullable: true),
                    FilterCustomersByCountry = table.Column<string>(nullable: true),
                    InactiveReason = table.Column<string>(nullable: true),
                    UseDaylightSavingsTime = table.Column<bool>(nullable: false),
                    TimezoneIANA = table.Column<string>(nullable: true),
                    IsPayoutByOrderDetail = table.Column<bool>(nullable: false),
                    LimitID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Franchises", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Franchises_Limit_LimitID",
                        column: x => x.LimitID,
                        principalTable: "Limit",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LimitDetail",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReplicationID = table.Column<Guid>(nullable: false),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedByStaffID = table.Column<int>(nullable: true),
                    LimitID = table.Column<int>(nullable: false),
                    LimitTypeID = table.Column<int>(nullable: false),
                    Frequency = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LimitDetail", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LimitDetail_Limit_LimitID",
                        column: x => x.LimitID,
                        principalTable: "Limit",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LimitDetail_LimitType_LimitTypeID",
                        column: x => x.LimitTypeID,
                        principalTable: "LimitType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Promotions_EventBonusing_Events",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReplicationID = table.Column<Guid>(nullable: false),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedByStaffID = table.Column<int>(nullable: true),
                    PromotionID = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    EventTypeID = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    StartDateTime = table.Column<DateTime>(nullable: true),
                    EndDateTime = table.Column<DateTime>(nullable: true),
                    QualifyByDateTime = table.Column<DateTime>(nullable: true),
                    BonusType = table.Column<string>(nullable: true),
                    CustomerBalanceTypeID = table.Column<int>(nullable: false),
                    BonusAmount = table.Column<decimal>(nullable: false),
                    MinimumQualifyingAmount = table.Column<decimal>(nullable: false),
                    MaximumBonusAwardAmount = table.Column<decimal>(nullable: false),
                    SpendMultiplier = table.Column<decimal>(nullable: false),
                    SpendMultiplierAmountType = table.Column<string>(nullable: true),
                    Promotions_EventBonusing_EventTypesID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotions_EventBonusing_Events", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Promotions_EventBonusing_Events_CustomerBalanceType_CustomerBalanceTypeID",
                        column: x => x.CustomerBalanceTypeID,
                        principalTable: "CustomerBalanceType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Promotions_EventBonusing_Events_Promotions_EventBonusing_EventTypes_Promotions_EventBonusing_EventTypesID",
                        column: x => x.Promotions_EventBonusing_EventTypesID,
                        principalTable: "Promotions_EventBonusing_EventTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Staff_Job_TransactionTypes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReplicationID = table.Column<Guid>(nullable: false),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedByStaffID = table.Column<int>(nullable: true),
                    Staff_Job_ID = table.Column<int>(nullable: false),
                    TransactionTypeID = table.Column<int>(nullable: false),
                    CanReview = table.Column<bool>(nullable: false),
                    Staff_JobsID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff_Job_TransactionTypes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Staff_Job_TransactionTypes_Staff_Jobs_Staff_JobsID",
                        column: x => x.Staff_JobsID,
                        principalTable: "Staff_Jobs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Staff_Job_TransactionTypes_TransactionType_TransactionTypeID",
                        column: x => x.TransactionTypeID,
                        principalTable: "TransactionType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    ReplicationID = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ExternalCustomerID = table.Column<string>(nullable: true),
                    FranchiseID = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    InactiveReason = table.Column<string>(nullable: true),
                    MarkedInactiveByStaffID = table.Column<int>(nullable: true),
                    Alias = table.Column<string>(nullable: true),
                    LastSeenOn = table.Column<DateTime>(nullable: true),
                    CanMakeDeposits = table.Column<bool>(nullable: true),
                    CanMakeWithdraws = table.Column<bool>(nullable: true),
                    LastSeenIPAddress = table.Column<string>(nullable: true),
                    LastSeenHostName = table.Column<string>(nullable: true),
                    AssignedStaffID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Customers_Franchises_FranchiseID",
                        column: x => x.FranchiseID,
                        principalTable: "Franchises",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Drawing",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    ReplicationID = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    FranchiseID = table.Column<int>(nullable: false),
                    GameTypeID = table.Column<int>(nullable: false),
                    CustomLookupKey = table.Column<string>(nullable: true),
                    DrawingDT = table.Column<DateTime>(nullable: false),
                    CloseDT = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsPosted = table.Column<bool>(nullable: false),
                    PostedAtDT = table.Column<DateTime>(nullable: true),
                    CreatedByStaffID = table.Column<int>(nullable: true),
                    PostedByStaffID = table.Column<int>(nullable: true),
                    UnpostedByStaffID = table.Column<int>(nullable: true),
                    UnpostedAtDT = table.Column<DateTime>(nullable: true),
                    TimezoneID = table.Column<int>(nullable: true),
                    WasAutoPosted = table.Column<bool>(nullable: true),
                    CanBeAutoPosted = table.Column<bool>(nullable: false),
                    AutoPostingInactiveReason = table.Column<string>(nullable: true),
                    StartDT = table.Column<DateTime>(nullable: true),
                    OriginalDrawsOn = table.Column<DateTime>(nullable: false),
                    WeekAndYearCode = table.Column<string>(nullable: true),
                    TimezoneIANA = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drawing", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Drawing_Franchises_FranchiseID",
                        column: x => x.FranchiseID,
                        principalTable: "Franchises",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Drawing_GameType_GameTypeID",
                        column: x => x.GameTypeID,
                        principalTable: "GameType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormFields_ConfigurationSettings",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FormID = table.Column<int>(nullable: false),
                    FranchiseID = table.Column<int>(nullable: false),
                    FieldName = table.Column<string>(nullable: true),
                    IsRequired = table.Column<bool>(nullable: false),
                    IsDisplayed = table.Column<bool>(nullable: false),
                    ExtraInfo = table.Column<string>(nullable: true),
                    IsUnique = table.Column<bool>(nullable: false),
                    MinLength = table.Column<int>(nullable: true),
                    GeneralDomainID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormFields_ConfigurationSettings", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FormFields_ConfigurationSettings_Franchises_FranchiseID",
                        column: x => x.FranchiseID,
                        principalTable: "Franchises",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormFields_ConfigurationSettings_GeneralDomain_GeneralDomainID",
                        column: x => x.GeneralDomainID,
                        principalTable: "GeneralDomain",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Games_Lottery_BallLimits",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    ReplicationID = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedByID = table.Column<long>(nullable: true),
                    FranchiseID = table.Column<int>(nullable: true),
                    OrderSourceID = table.Column<int>(nullable: true),
                    LottoGameTypeID = table.Column<string>(nullable: true),
                    B1 = table.Column<string>(nullable: true),
                    B2 = table.Column<string>(nullable: true),
                    B3 = table.Column<string>(nullable: true),
                    B4 = table.Column<string>(nullable: true),
                    B5 = table.Column<string>(nullable: true),
                    B6 = table.Column<string>(nullable: true),
                    B7 = table.Column<string>(nullable: true),
                    B8 = table.Column<string>(nullable: true),
                    B9 = table.Column<string>(nullable: true),
                    B10 = table.Column<string>(nullable: true),
                    TotalLimit = table.Column<decimal>(nullable: true),
                    Games_Lottery_GameTypesID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games_Lottery_BallLimits", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Games_Lottery_BallLimits_Franchises_FranchiseID",
                        column: x => x.FranchiseID,
                        principalTable: "Franchises",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Games_Lottery_BallLimits_Games_Lottery_GameTypes_Games_Lottery_GameTypesID",
                        column: x => x.Games_Lottery_GameTypesID,
                        principalTable: "Games_Lottery_GameTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Games_Lottery_Games",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    ReplicationID = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    FranchiseID = table.Column<int>(nullable: false),
                    LotteryGameTypeID = table.Column<string>(nullable: true),
                    BallCount = table.Column<byte>(nullable: false),
                    ClosesAtTime = table.Column<string>(nullable: true),
                    DrawsAtTime = table.Column<string>(nullable: true),
                    DrawingOnSunday = table.Column<bool>(nullable: false),
                    DrawingOnMonday = table.Column<bool>(nullable: false),
                    DrawingOnTuesday = table.Column<bool>(nullable: false),
                    DrawingOnWednesday = table.Column<bool>(nullable: false),
                    DrawingOnThursday = table.Column<bool>(nullable: false),
                    DrawingOnFriday = table.Column<bool>(nullable: false),
                    DrawingOnSaturday = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDisplayed = table.Column<bool>(nullable: false),
                    PayoutFactor = table.Column<decimal>(nullable: false),
                    PayoutFactor2 = table.Column<decimal>(nullable: true),
                    PayoutFactor3 = table.Column<decimal>(nullable: true),
                    MaxBetLimit = table.Column<decimal>(nullable: true),
                    MinimumNumberPerBall = table.Column<int>(nullable: false),
                    MaximumNumberPerBall = table.Column<int>(nullable: false),
                    MinimumAmountPerBet = table.Column<decimal>(nullable: true),
                    MaximumAmountPerBet = table.Column<decimal>(nullable: true),
                    BallCountOnOrder = table.Column<byte>(nullable: true),
                    LotteryType = table.Column<string>(nullable: true),
                    JackpotID = table.Column<short>(nullable: true),
                    IsManuallyCreated = table.Column<bool>(nullable: false),
                    ExtraBallCount = table.Column<int>(nullable: true),
                    ExtraBallMinimumNumberPerBall = table.Column<int>(nullable: true),
                    ExtraBallMaximumNumberPerBall = table.Column<int>(nullable: true),
                    MinimumBallCountOnOrder = table.Column<byte>(nullable: true),
                    MaximumBallCountOnOrder = table.Column<byte>(nullable: true),
                    Grading_LowPercentage = table.Column<decimal>(nullable: true),
                    Grading_HighPercentage = table.Column<decimal>(nullable: true),
                    Denominations = table.Column<string>(nullable: true),
                    CanBeAutoPosted = table.Column<bool>(nullable: false),
                    OddsOfWinning = table.Column<decimal>(nullable: true),
                    AutoPostingInactiveReason = table.Column<string>(nullable: true),
                    InactiveReason = table.Column<string>(nullable: true),
                    ScheduleGroupID = table.Column<long>(nullable: true),
                    Games_Lottery_ExternalLottery_ID = table.Column<int>(nullable: true),
                    ExtraPlayAddedAmount = table.Column<decimal>(nullable: true),
                    ClosesAtTime_DST = table.Column<string>(nullable: true),
                    DrawsAtTime_DST = table.Column<string>(nullable: true),
                    CloseTimeOffset_Minutes = table.Column<int>(nullable: true),
                    ExtraBallCountOnOrder = table.Column<int>(nullable: true),
                    JackpotGroupID = table.Column<short>(nullable: true),
                    Fractions = table.Column<short>(nullable: true),
                    Games_Lottery_Games_GroupsID = table.Column<long>(nullable: true),
                    StartTimeOffset_Minutes = table.Column<int>(nullable: true),
                    OrderValidDays = table.Column<int>(nullable: true),
                    IsDependentOnGame = table.Column<bool>(nullable: false),
                    Dependent_LotteryGameTypeID = table.Column<string>(nullable: true),
                    NumberProviderIdentifier = table.Column<string>(nullable: true),
                    AllowedBallCountsOnOrder = table.Column<string>(nullable: true),
                    Games_Lottery_GameTypesID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games_Lottery_Games", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Games_Lottery_Games_Franchises_FranchiseID",
                        column: x => x.FranchiseID,
                        principalTable: "Franchises",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Games_Lottery_Games_Games_Lottery_GameTypes_Games_Lottery_GameTypesID",
                        column: x => x.Games_Lottery_GameTypesID,
                        principalTable: "Games_Lottery_GameTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Media_Code_Groups",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReplicationID = table.Column<Guid>(nullable: false),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedByStaffID = table.Column<int>(nullable: true),
                    FranchiseID = table.Column<int>(nullable: false),
                    GroupKey = table.Column<string>(nullable: true),
                    DisplayName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Media_Code_Groups", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Media_Code_Groups_Franchises_FranchiseID",
                        column: x => x.FranchiseID,
                        principalTable: "Franchises",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Media_Codes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReplicationID = table.Column<Guid>(nullable: false),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedByStaffID = table.Column<int>(nullable: true),
                    ChangedOn = table.Column<DateTime>(nullable: true),
                    ChangedByStaffID = table.Column<int>(nullable: true),
                    MediaCode = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    PartnerName = table.Column<string>(nullable: true),
                    FranchiseID = table.Column<int>(nullable: false),
                    MediaTitle = table.Column<string>(nullable: true),
                    TeaserProduct = table.Column<string>(nullable: true),
                    Circulation = table.Column<string>(nullable: true),
                    PublicationDate = table.Column<DateTime>(nullable: true),
                    Version = table.Column<string>(nullable: true),
                    Selection = table.Column<string>(nullable: true),
                    PrintCosts = table.Column<decimal>(nullable: true),
                    CallCenterCosts = table.Column<decimal>(nullable: true),
                    MediaCosts = table.Column<decimal>(nullable: true),
                    FreeLineCosts = table.Column<decimal>(nullable: true),
                    MediaCodeGroupID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Media_Codes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Media_Codes_Franchises_FranchiseID",
                        column: x => x.FranchiseID,
                        principalTable: "Franchises",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderBundle",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReplicationID = table.Column<Guid>(nullable: false),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedByStaffID = table.Column<int>(nullable: true),
                    FranchiseID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderBundle", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OrderBundle_Franchises_FranchiseID",
                        column: x => x.FranchiseID,
                        principalTable: "Franchises",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Promotion_Franchises",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    ReplicationID = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: true),
                    FranchiseID = table.Column<int>(nullable: false),
                    PromotionID = table.Column<int>(nullable: false),
                    ConfigurationID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotion_Franchises", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Promotion_Franchises_Franchises_FranchiseID",
                        column: x => x.FranchiseID,
                        principalTable: "Franchises",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Promotion_Franchises_Promotion_PromotionID",
                        column: x => x.PromotionID,
                        principalTable: "Promotion",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReplicationID = table.Column<Guid>(nullable: false),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    UserID = table.Column<Guid>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedByStaffID = table.Column<int>(nullable: true),
                    LastChangedOn = table.Column<DateTime>(nullable: true),
                    LastChangedByStaffID = table.Column<int>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    FranchiseID = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    InactiveReason = table.Column<string>(nullable: true),
                    LanguageID = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    CellPhone = table.Column<string>(nullable: true),
                    AlternatePhone = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    LocationID = table.Column<int>(nullable: true),
                    ThirdPartyID = table.Column<int>(nullable: true),
                    JobID = table.Column<int>(nullable: true),
                    LastSignedInOn = table.Column<DateTime>(nullable: true),
                    LastSeenOn = table.Column<DateTime>(nullable: true),
                    LastIPAddress = table.Column<string>(nullable: true),
                    LastTerminalIDUsed = table.Column<int>(nullable: true),
                    ResetPasswordOnNextSignIn = table.Column<bool>(nullable: false),
                    CanMakeCustomerDeposits = table.Column<bool>(nullable: true),
                    CanMakeCustomerWithdraws = table.Column<bool>(nullable: true),
                    IsTOTPRequired = table.Column<bool>(nullable: false),
                    TOTPUserKey = table.Column<string>(nullable: true),
                    PINHash = table.Column<string>(nullable: true),
                    PINSalt = table.Column<string>(nullable: true),
                    ThemePreference = table.Column<int>(nullable: false),
                    Staff_JobsID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Staff_Franchises_FranchiseID",
                        column: x => x.FranchiseID,
                        principalTable: "Franchises",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Staff_Staff_Jobs_Staff_JobsID",
                        column: x => x.Staff_JobsID,
                        principalTable: "Staff_Jobs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Syndicate",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReplicationID = table.Column<Guid>(nullable: false),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedByStaffID = table.Column<int>(nullable: true),
                    ChangedOn = table.Column<DateTime>(nullable: true),
                    ChangedByStaffID = table.Column<int>(nullable: true),
                    FranchiseID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    RequiresChoosingNumbers = table.Column<bool>(nullable: false),
                    RequiresMerchantShare = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsClosed = table.Column<bool>(nullable: false),
                    IsFree = table.Column<bool>(nullable: false),
                    ShareBuysAllGames = table.Column<bool>(nullable: false),
                    CostPerShare = table.Column<decimal>(nullable: true),
                    PerDrawingPeriods = table.Column<bool>(nullable: false),
                    ImageData = table.Column<string>(nullable: true),
                    ImageMimeType = table.Column<string>(nullable: true),
                    IsPromo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Syndicate", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Syndicate_Franchises_FranchiseID",
                        column: x => x.FranchiseID,
                        principalTable: "Franchises",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerAccount",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReplicationID = table.Column<Guid>(nullable: false),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedByStaffID = table.Column<int>(nullable: true),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    ModifiedByStaffID = table.Column<int>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    UserID = table.Column<Guid>(nullable: false),
                    CustomerID = table.Column<long>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    EmailAddressVerified = table.Column<DateTime>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberStripped = table.Column<string>(nullable: true),
                    PhoneNumberVerified = table.Column<DateTime>(nullable: true),
                    CellPhone = table.Column<string>(nullable: true),
                    CellPhoneStripped = table.Column<string>(nullable: true),
                    PINHash = table.Column<string>(nullable: true),
                    PINSalt = table.Column<string>(nullable: true),
                    IsDocumentationVerified = table.Column<bool>(nullable: false),
                    DocumentationVerified = table.Column<DateTime>(nullable: true),
                    IsExemptFromDocumentVerification = table.Column<bool>(nullable: false),
                    CardID = table.Column<string>(nullable: true),
                    AddressLine1 = table.Column<string>(nullable: true),
                    AddressLine2 = table.Column<string>(nullable: true),
                    AddressLine3 = table.Column<string>(nullable: true),
                    AddressLine4 = table.Column<string>(nullable: true),
                    Locality = table.Column<string>(nullable: true),
                    Region = table.Column<string>(nullable: true),
                    Postcode = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Employer = table.Column<string>(nullable: true),
                    IsDomestic = table.Column<bool>(nullable: false),
                    IsTermsExplained = table.Column<bool>(nullable: false),
                    AddressVerified = table.Column<DateTime>(nullable: true),
                    ApprovedOn = table.Column<DateTime>(nullable: true),
                    ApprovedByStaffID = table.Column<int>(nullable: true),
                    DeniedOn = table.Column<DateTime>(nullable: true),
                    DeniedByStaffID = table.Column<int>(nullable: true),
                    DenialReason = table.Column<string>(nullable: true),
                    SystemImposedLimitID = table.Column<int>(nullable: true),
                    SelfImposedLimitID = table.Column<int>(nullable: true),
                    IsRequiringPasswordUpdate = table.Column<bool>(nullable: false),
                    TransactionIDOfFirstCustomerDeposit = table.Column<long>(nullable: true),
                    AffiliateID = table.Column<int>(nullable: true),
                    IsExemptFromLocationChecks = table.Column<bool>(nullable: false),
                    IsTestCustomer = table.Column<bool>(nullable: false),
                    IsWalletApplicationTestCustomer = table.Column<bool>(nullable: false),
                    CellPhoneVerified = table.Column<DateTime>(nullable: true),
                    MediaCodeID = table.Column<int>(nullable: true),
                    Syndicate_HadFreeSyndicate = table.Column<bool>(nullable: false),
                    AddressService_MatchingAddressesFound = table.Column<bool>(nullable: true),
                    AddressService_StaffOverrodeFoundAddress = table.Column<bool>(nullable: true),
                    IsAccountUnderReview = table.Column<bool>(nullable: false),
                    AccountUnderReviewReason = table.Column<string>(nullable: true),
                    AccountUnderReviewReasonDetails = table.Column<string>(nullable: true),
                    AgeVerified = table.Column<DateTime>(nullable: true),
                    AgeVerificationOverridden = table.Column<DateTime>(nullable: true),
                    AgeVerificationOverriddenStaffID = table.Column<int>(nullable: true),
                    AffiliateExtraData = table.Column<string>(nullable: true),
                    Prefix = table.Column<string>(nullable: true),
                    Suffix = table.Column<string>(nullable: true),
                    OptIn_Important = table.Column<bool>(nullable: false),
                    OptIn_Marketing = table.Column<bool>(nullable: false),
                    IsTOTPRequired = table.Column<bool>(nullable: false),
                    TOTPUserKey = table.Column<string>(nullable: true),
                    ImportNotes = table.Column<string>(nullable: true),
                    ImportedIdentifier = table.Column<string>(nullable: true),
                    CustomerID1 = table.Column<int>(nullable: true),
                    LimitID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerAccount", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CustomerAccount_Customers_CustomerID1",
                        column: x => x.CustomerID1,
                        principalTable: "Customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CustomerAccount_Limit_LimitID",
                        column: x => x.LimitID,
                        principalTable: "Limit",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    ReplicationID = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LocationID = table.Column<int>(nullable: true),
                    StaffID = table.Column<int>(nullable: true),
                    CreatedByID = table.Column<int>(nullable: true),
                    LastChangedOn = table.Column<DateTime>(nullable: true),
                    LastChangedByID = table.Column<int>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    OrderSourceID = table.Column<int>(nullable: false),
                    TotalPrice = table.Column<decimal>(nullable: true),
                    IsVoid = table.Column<bool>(nullable: false),
                    ChainedFromOrderID = table.Column<long>(nullable: true),
                    ThirdPartyID = table.Column<int>(nullable: true),
                    ClientOrderID = table.Column<long>(nullable: true),
                    IsPostedOffline = table.Column<bool>(nullable: false),
                    IsSystemVoid = table.Column<bool>(nullable: false),
                    IsOnPaymentPlan = table.Column<bool>(nullable: false),
                    PaymentPlanGUID = table.Column<Guid>(nullable: true),
                    CanNotBeVoided = table.Column<bool>(nullable: false),
                    CanNotBeVoidedCreatedOn = table.Column<DateTime>(nullable: true),
                    CanNotBeVoidedReason = table.Column<string>(nullable: true),
                    LotterySoftwareVersion = table.Column<string>(nullable: true),
                    IsReplayTicket = table.Column<bool>(nullable: true),
                    TotalTaxPercentage = table.Column<decimal>(nullable: false),
                    TotalTaxCharged = table.Column<decimal>(nullable: false),
                    CustomersID = table.Column<int>(nullable: true),
                    FranchiseID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Order_Customers_CustomersID",
                        column: x => x.CustomersID,
                        principalTable: "Customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_Franchises_FranchiseID",
                        column: x => x.FranchiseID,
                        principalTable: "Franchises",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    ReplicationID = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LocationID = table.Column<int>(nullable: true),
                    StaffID = table.Column<int>(nullable: true),
                    CreatedByID = table.Column<int>(nullable: true),
                    LastChangedOn = table.Column<DateTime>(nullable: true),
                    LastChangedByID = table.Column<int>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    OrderSourceID = table.Column<int>(nullable: false),
                    TotalPrice = table.Column<decimal>(nullable: true),
                    IsVoid = table.Column<bool>(nullable: false),
                    ChainedFromOrderID = table.Column<long>(nullable: true),
                    ThirdPartyID = table.Column<int>(nullable: true),
                    ClientOrderID = table.Column<long>(nullable: true),
                    IsPostedOffline = table.Column<bool>(nullable: false),
                    IsSystemVoid = table.Column<bool>(nullable: false),
                    IsOnPaymentPlan = table.Column<bool>(nullable: false),
                    PaymentPlanGUID = table.Column<Guid>(nullable: false),
                    CanNotBeVoided = table.Column<bool>(nullable: false),
                    CanNotBeVoidedCreatedOn = table.Column<DateTime>(nullable: true),
                    CanNotBeVoidedReason = table.Column<string>(nullable: true),
                    LotterySoftwareVersion = table.Column<string>(nullable: true),
                    IsReplayTicket = table.Column<bool>(nullable: true),
                    TotalTaxPercentage = table.Column<decimal>(nullable: false),
                    TotalTaxCharged = table.Column<decimal>(nullable: false),
                    CustomersID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomersID",
                        column: x => x.CustomersID,
                        principalTable: "Customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Games_Lottery_Drawings",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    ReplicationID = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    DrawingID = table.Column<long>(nullable: false),
                    LotteryGameID = table.Column<long>(nullable: false),
                    B1 = table.Column<string>(nullable: true),
                    B2 = table.Column<string>(nullable: true),
                    B3 = table.Column<string>(nullable: true),
                    B4 = table.Column<string>(nullable: true),
                    B5 = table.Column<string>(nullable: true),
                    B6 = table.Column<string>(nullable: true),
                    B7 = table.Column<string>(nullable: true),
                    B8 = table.Column<string>(nullable: true),
                    B9 = table.Column<string>(nullable: true),
                    B10 = table.Column<string>(nullable: true),
                    B11 = table.Column<string>(nullable: true),
                    B12 = table.Column<string>(nullable: true),
                    B13 = table.Column<string>(nullable: true),
                    B14 = table.Column<string>(nullable: true),
                    B15 = table.Column<string>(nullable: true),
                    B16 = table.Column<string>(nullable: true),
                    B17 = table.Column<string>(nullable: true),
                    B18 = table.Column<string>(nullable: true),
                    B19 = table.Column<string>(nullable: true),
                    B20 = table.Column<string>(nullable: true),
                    PayoutFactor = table.Column<decimal>(nullable: false),
                    AutoPostLastAttemptedAt = table.Column<DateTime>(nullable: true),
                    Games_Lottery_Drawings_GroupID = table.Column<long>(nullable: true),
                    UnsortedBallString = table.Column<string>(nullable: true),
                    SortedBallString = table.Column<string>(nullable: true),
                    Games_Lottery_GamesID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games_Lottery_Drawings", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Games_Lottery_Drawings_Drawing_DrawingID",
                        column: x => x.DrawingID,
                        principalTable: "Drawing",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Games_Lottery_Drawings_Games_Lottery_Drawings_Group_Games_Lottery_Drawings_GroupID",
                        column: x => x.Games_Lottery_Drawings_GroupID,
                        principalTable: "Games_Lottery_Drawings_Group",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Games_Lottery_Drawings_Games_Lottery_Games_Games_Lottery_GamesID",
                        column: x => x.Games_Lottery_GamesID,
                        principalTable: "Games_Lottery_Games",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Syndicate_Games",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReplicationID = table.Column<Guid>(nullable: false),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedByStaffID = table.Column<int>(nullable: true),
                    ChangedOn = table.Column<DateTime>(nullable: true),
                    ChangedByStaffID = table.Column<int>(nullable: true),
                    InternalName = table.Column<string>(nullable: true),
                    Games_Lottery_Games_ID = table.Column<long>(nullable: false),
                    PoolSize = table.Column<int>(nullable: false),
                    CostPerShare = table.Column<decimal>(nullable: true),
                    LinesPerPool = table.Column<int>(nullable: false),
                    MinPoolSizeForPurchase = table.Column<int>(nullable: true),
                    LengthOfPrepPhaseDays = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsClosed = table.Column<bool>(nullable: false),
                    IsFree = table.Column<bool>(nullable: false),
                    RequiresChoosingNumbers = table.Column<bool>(nullable: false),
                    RequiresMerchantShare = table.Column<bool>(nullable: false),
                    FranchiseID = table.Column<int>(nullable: false),
                    PerDrawingPeriods = table.Column<bool>(nullable: false),
                    IsDefault = table.Column<bool>(nullable: false),
                    FullPoolsNotRequired = table.Column<bool>(nullable: false),
                    Games_Lottery_GamesID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Syndicate_Games", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Syndicate_Games_Franchises_FranchiseID",
                        column: x => x.FranchiseID,
                        principalTable: "Franchises",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Syndicate_Games_Games_Lottery_Games_Games_Lottery_GamesID",
                        column: x => x.Games_Lottery_GamesID,
                        principalTable: "Games_Lottery_Games",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Staff_Sessions",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReplicationID = table.Column<Guid>(nullable: false),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    StaffID = table.Column<int>(nullable: false),
                    SignedInOn = table.Column<DateTime>(nullable: false),
                    SignedOutOn = table.Column<DateTime>(nullable: true),
                    DateTimeLastSeen = table.Column<DateTime>(nullable: false),
                    TerminalTypeID = table.Column<int>(nullable: false),
                    IPAddress = table.Column<string>(nullable: true),
                    HostName = table.Column<string>(nullable: true),
                    BrowserDetails = table.Column<string>(nullable: true),
                    SignOutType = table.Column<string>(nullable: true),
                    ForcedOutByStaffID = table.Column<int>(nullable: true),
                    ForcedReason = table.Column<string>(nullable: true),
                    SessionID = table.Column<string>(nullable: true),
                    GeoLookupCountry = table.Column<string>(nullable: true),
                    GeoLookupAreaName = table.Column<string>(nullable: true),
                    GeoLookupLatitude = table.Column<decimal>(nullable: true),
                    GeoLookupLongitude = table.Column<decimal>(nullable: true),
                    GeoLookupIdentifier = table.Column<string>(nullable: true),
                    TerminalID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff_Sessions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Staff_Sessions_Staff_StaffID",
                        column: x => x.StaffID,
                        principalTable: "Staff",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderBundle_Detail",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReplicationID = table.Column<Guid>(nullable: false),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedByStaffID = table.Column<int>(nullable: true),
                    OrderBundleID = table.Column<int>(nullable: false),
                    Games_Lottery_GamesID = table.Column<long>(nullable: true),
                    SyndicateID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    PriceForPayout = table.Column<decimal>(nullable: true),
                    IsBoxed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderBundle_Detail", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OrderBundle_Detail_Games_Lottery_Games_Games_Lottery_GamesID",
                        column: x => x.Games_Lottery_GamesID,
                        principalTable: "Games_Lottery_Games",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderBundle_Detail_OrderBundle_OrderBundleID",
                        column: x => x.OrderBundleID,
                        principalTable: "OrderBundle",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderBundle_Detail_Syndicate_SyndicateID",
                        column: x => x.SyndicateID,
                        principalTable: "Syndicate",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Syndicate_MediaCodes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReplicationID = table.Column<Guid>(nullable: false),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedByStaffID = table.Column<int>(nullable: true),
                    SyndicateID = table.Column<int>(nullable: false),
                    MediaCodeID = table.Column<int>(nullable: false),
                    Media_CodesID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Syndicate_MediaCodes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Syndicate_MediaCodes_Media_Codes_Media_CodesID",
                        column: x => x.Media_CodesID,
                        principalTable: "Media_Codes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Syndicate_MediaCodes_Syndicate_SyndicateID",
                        column: x => x.SyndicateID,
                        principalTable: "Syndicate",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customer_Billing_Queue_Detail",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReplicationID = table.Column<Guid>(nullable: false),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    Customer_Billing_QueueID = table.Column<long>(nullable: false),
                    CustomerAccountID = table.Column<long>(nullable: true),
                    ShareCount = table.Column<int>(nullable: true),
                    Amount = table.Column<decimal>(nullable: false),
                    IsManualPayment = table.Column<bool>(nullable: false),
                    PeriodID = table.Column<long>(nullable: true),
                    PoolID = table.Column<long>(nullable: true),
                    SyndicateOrderID = table.Column<long>(nullable: true),
                    OrderDetailID = table.Column<long>(nullable: true),
                    ConversionRate = table.Column<decimal>(nullable: true),
                    PrepTransactionID = table.Column<long>(nullable: true),
                    TransactionID = table.Column<long>(nullable: true),
                    ProcessedOn = table.Column<DateTime>(nullable: true),
                    ResponseStatus = table.Column<string>(nullable: true),
                    ResponseMessage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer_Billing_Queue_Detail", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Customer_Billing_Queue_Detail_CustomerAccount_CustomerAccountID",
                        column: x => x.CustomerAccountID,
                        principalTable: "CustomerAccount",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customer_Billing_Queue_Detail_Customer_Billing_Queue_Customer_Billing_QueueID",
                        column: x => x.Customer_Billing_QueueID,
                        principalTable: "Customer_Billing_Queue",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerAccounts_Exclusions",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReplicationID = table.Column<Guid>(nullable: false),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    CustomerAccountID = table.Column<long>(nullable: false),
                    ExclusionStartsOn = table.Column<DateTime>(nullable: false),
                    ExclusionEndsOn = table.Column<DateTime>(nullable: true),
                    ExclusionEndedOn = table.Column<DateTime>(nullable: true),
                    IsSelfExcluded = table.Column<bool>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    IsPermittedToWithdrawFunds = table.Column<bool>(nullable: false),
                    IsRequiredToWithdrawAllFunds = table.Column<bool>(nullable: false),
                    CustomerRequestedCancellationOn = table.Column<DateTime>(nullable: true),
                    CancellationRequestDeniedOn = table.Column<DateTime>(nullable: true),
                    CancellationRequestDeniedByStaffID = table.Column<int>(nullable: true),
                    CancellationRequestApprovedOn = table.Column<DateTime>(nullable: true),
                    CancellationRequestApprovedByStaffID = table.Column<int>(nullable: true),
                    CancellationRequestDenialReason = table.Column<string>(nullable: true),
                    ExcludedByStaffID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerAccounts_Exclusions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CustomerAccounts_Exclusions_CustomerAccount_CustomerAccountID",
                        column: x => x.CustomerAccountID,
                        principalTable: "CustomerAccount",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerBalance",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReplicationID = table.Column<Guid>(nullable: false),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedByStaffID = table.Column<int>(nullable: true),
                    CustomerAccountID = table.Column<long>(nullable: false),
                    BalanceTypeID = table.Column<int>(nullable: false),
                    Balance = table.Column<decimal>(nullable: true),
                    BonusEventID = table.Column<int>(nullable: true),
                    TransactionID = table.Column<long>(nullable: true),
                    StartCheckDate = table.Column<DateTime>(nullable: true),
                    RewardLevelID = table.Column<int>(nullable: true),
                    CustomerBalanceTypeID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerBalance", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CustomerBalance_CustomerAccount_CustomerAccountID",
                        column: x => x.CustomerAccountID,
                        principalTable: "CustomerAccount",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerBalance_CustomerBalanceType_CustomerBalanceTypeID",
                        column: x => x.CustomerBalanceTypeID,
                        principalTable: "CustomerBalanceType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    ReplicationID = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    AppliesToDateTime = table.Column<DateTime>(nullable: false),
                    CustomerID = table.Column<long>(nullable: true),
                    TransactionTypeID = table.Column<int>(nullable: false),
                    Amount = table.Column<decimal>(nullable: true),
                    PreAmount = table.Column<decimal>(nullable: true),
                    PostAmount = table.Column<decimal>(nullable: true),
                    OrderSourceID = table.Column<int>(nullable: true),
                    GameTypeID = table.Column<int>(nullable: true),
                    OrderID = table.Column<long>(nullable: true),
                    FranchiseID = table.Column<int>(nullable: false),
                    LocationID = table.Column<int>(nullable: true),
                    StaffID = table.Column<int>(nullable: false),
                    ThirdPartyID = table.Column<int>(nullable: false),
                    TerminalID = table.Column<int>(nullable: false),
                    ForwardedToWallet = table.Column<bool>(nullable: false),
                    ForwardedSuccessOn = table.Column<DateTime>(nullable: true),
                    ForwardedLastFailedOn = table.Column<DateTime>(nullable: true),
                    ForwardingIdentifier = table.Column<string>(nullable: true),
                    ExternalTransactionID = table.Column<long>(nullable: true),
                    CreatedByStaffID = table.Column<int>(nullable: true),
                    ForwardingFailCount = table.Column<int>(nullable: false),
                    CustomerBalanceID = table.Column<long>(nullable: true),
                    IsSystemVoid = table.Column<bool>(nullable: false),
                    RelatedToTransactionID = table.Column<long>(nullable: true),
                    IsNeedingReview = table.Column<bool>(nullable: false),
                    CustomerSessionID = table.Column<long>(nullable: true),
                    BankID = table.Column<int>(nullable: true),
                    IsCorrection = table.Column<bool>(nullable: false),
                    DisbursementCategoryID = table.Column<int>(nullable: true),
                    WalletApplicationID = table.Column<int>(nullable: true),
                    ExternalSessionID = table.Column<string>(nullable: true),
                    ExternalGameID = table.Column<string>(nullable: true),
                    ExternalReferenceID = table.Column<string>(nullable: true),
                    CorrectedByStaffID = table.Column<int>(nullable: true),
                    CorrectedOn = table.Column<DateTime>(nullable: true),
                    CorrectedTransactionID = table.Column<long>(nullable: true),
                    IsCorrected = table.Column<bool>(nullable: false),
                    CorrectionByStaffID = table.Column<int>(nullable: true),
                    CorrectionOn = table.Column<DateTime>(nullable: true),
                    CorrectionTransactionID = table.Column<long>(nullable: true),
                    StaffSessionID = table.Column<long>(nullable: true),
                    PromotionID = table.Column<int>(nullable: true),
                    PromotionSubID = table.Column<int>(nullable: true),
                    JackpotID = table.Column<short>(nullable: true),
                    ExternalRoundID = table.Column<string>(nullable: true),
                    ReviewedByStaffID = table.Column<int>(nullable: true),
                    ReviewedOn = table.Column<DateTime>(nullable: true),
                    DrawingID = table.Column<long>(nullable: true),
                    LimitID = table.Column<int>(nullable: true),
                    OrderDetails_Lottery_ID = table.Column<long>(nullable: true),
                    TaxRate = table.Column<decimal>(nullable: false),
                    PaymentTypeID = table.Column<int>(nullable: false),
                    NotifiedOn = table.Column<DateTime>(nullable: true),
                    CustomerID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Transaction_Customers_CustomerID1",
                        column: x => x.CustomerID1,
                        principalTable: "Customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transaction_Franchises_FranchiseID",
                        column: x => x.FranchiseID,
                        principalTable: "Franchises",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transaction_Order_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transaction_TransactionType_TransactionTypeID",
                        column: x => x.TransactionTypeID,
                        principalTable: "TransactionType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Syndicate_Games_Link",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReplicationID = table.Column<Guid>(nullable: false),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedByStaffID = table.Column<int>(nullable: true),
                    SyndicateID = table.Column<int>(nullable: false),
                    SyndicateGameID = table.Column<int>(nullable: false),
                    DisplayName = table.Column<string>(nullable: true),
                    ImageData = table.Column<string>(nullable: true),
                    ImageMimeType = table.Column<string>(nullable: true),
                    Syndicate_GamesID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Syndicate_Games_Link", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Syndicate_Games_Link_Syndicate_SyndicateID",
                        column: x => x.SyndicateID,
                        principalTable: "Syndicate",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Syndicate_Games_Link_Syndicate_Games_Syndicate_GamesID",
                        column: x => x.Syndicate_GamesID,
                        principalTable: "Syndicate_Games",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Syndicate_Periods",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReplicationID = table.Column<Guid>(nullable: false),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    SyndicateGameID = table.Column<int>(nullable: false),
                    PrepPeriodStartDate = table.Column<DateTime>(nullable: true),
                    PlayPeriodStartDate = table.Column<DateTime>(nullable: true),
                    PlayPeriodEndDate = table.Column<DateTime>(nullable: true),
                    DrawingID = table.Column<long>(nullable: true),
                    PeriodIntendedDate = table.Column<DateTime>(nullable: true),
                    Previous_PeriodID = table.Column<long>(nullable: true),
                    QueueingComplete = table.Column<bool>(nullable: false),
                    LastOrderDate = table.Column<DateTime>(nullable: true),
                    PreviousWinningsLastDate = table.Column<DateTime>(nullable: true),
                    Syndicate_GamesID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Syndicate_Periods", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Syndicate_Periods_Syndicate_Games_Syndicate_GamesID",
                        column: x => x.Syndicate_GamesID,
                        principalTable: "Syndicate_Games",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails_Lottery",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    ReplicationID = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastChangedOn = table.Column<DateTime>(nullable: true),
                    OrderID = table.Column<long>(nullable: false),
                    DrawingID = table.Column<long>(nullable: false),
                    B1 = table.Column<string>(nullable: true),
                    B2 = table.Column<string>(nullable: true),
                    B3 = table.Column<string>(nullable: true),
                    B4 = table.Column<string>(nullable: true),
                    B5 = table.Column<string>(nullable: true),
                    B6 = table.Column<string>(nullable: true),
                    IsBoxed = table.Column<bool>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    FractionalPrice = table.Column<decimal>(nullable: true),
                    CountOfCombinations = table.Column<short>(nullable: true),
                    CountOfMatches = table.Column<short>(nullable: true),
                    Payout = table.Column<decimal>(nullable: true),
                    IsWinner = table.Column<bool>(nullable: false),
                    IsPaid = table.Column<bool>(nullable: false),
                    IsLoss = table.Column<bool>(nullable: false),
                    IsComped = table.Column<bool>(nullable: false),
                    ReasonComped = table.Column<string>(nullable: true),
                    B7 = table.Column<string>(nullable: true),
                    B8 = table.Column<string>(nullable: true),
                    B9 = table.Column<string>(nullable: true),
                    B10 = table.Column<string>(nullable: true),
                    ShouldBeRefunded = table.Column<bool>(nullable: false),
                    IsRefunded = table.Column<bool>(nullable: false),
                    SortedBallString = table.Column<string>(nullable: true),
                    UnsortedBallString = table.Column<string>(nullable: true),
                    IsJackpotWinner = table.Column<bool>(nullable: false),
                    ExtraData = table.Column<string>(nullable: true),
                    B11 = table.Column<string>(nullable: true),
                    B12 = table.Column<string>(nullable: true),
                    B13 = table.Column<string>(nullable: true),
                    B14 = table.Column<string>(nullable: true),
                    B15 = table.Column<string>(nullable: true),
                    B16 = table.Column<string>(nullable: true),
                    B17 = table.Column<string>(nullable: true),
                    B18 = table.Column<string>(nullable: true),
                    B19 = table.Column<string>(nullable: true),
                    B20 = table.Column<string>(nullable: true),
                    Games_Lottery_Bigball_Payout_ID = table.Column<int>(nullable: true),
                    OrderedOnBehalfOfFullName = table.Column<string>(nullable: true),
                    OrderedOnBehalfOfCellNumber = table.Column<string>(nullable: true),
                    B21 = table.Column<string>(nullable: true),
                    B22 = table.Column<string>(nullable: true),
                    B23 = table.Column<string>(nullable: true),
                    B24 = table.Column<string>(nullable: true),
                    B25 = table.Column<string>(nullable: true),
                    TaxPercentage = table.Column<decimal>(nullable: false),
                    TaxCharged = table.Column<decimal>(nullable: false),
                    BetCount = table.Column<int>(nullable: false),
                    OrderBundle_DetailID = table.Column<int>(nullable: true),
                    OrderBundleID = table.Column<int>(nullable: true),
                    OrderBundle_Guid = table.Column<Guid>(nullable: true),
                    PayoutTaxPercentage = table.Column<decimal>(nullable: false),
                    PayoutTaxCharged = table.Column<decimal>(nullable: false),
                    OrdersID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails_Lottery", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Lottery_Drawing_DrawingID",
                        column: x => x.DrawingID,
                        principalTable: "Drawing",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Lottery_OrderBundle_Detail_OrderBundle_DetailID",
                        column: x => x.OrderBundle_DetailID,
                        principalTable: "OrderBundle_Detail",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Lottery_Order_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Lottery_Orders_OrdersID",
                        column: x => x.OrdersID,
                        principalTable: "Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails_Product",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReplicationID = table.Column<Guid>(nullable: false),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastChangedOn = table.Column<DateTime>(nullable: true),
                    OrderID = table.Column<long>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    IsComped = table.Column<bool>(nullable: false),
                    ReasonComped = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    SyndicateID = table.Column<int>(nullable: true),
                    TransactionID = table.Column<long>(nullable: true),
                    OrderBundleID = table.Column<int>(nullable: true),
                    OrderBundle_DetailID = table.Column<int>(nullable: true),
                    OrderBundle_Guid = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails_Product", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Product_OrderBundle_Detail_OrderBundle_DetailID",
                        column: x => x.OrderBundle_DetailID,
                        principalTable: "OrderBundle_Detail",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Product_Order_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Product_Syndicate_SyndicateID",
                        column: x => x.SyndicateID,
                        principalTable: "Syndicate",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Product_Transaction_TransactionID",
                        column: x => x.TransactionID,
                        principalTable: "Transaction",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Transactions_AdditionalInfo",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Notes = table.Column<string>(nullable: true),
                    ForwardingNotes = table.Column<string>(nullable: true),
                    ReviewNotes = table.Column<string>(nullable: true),
                    ReplicationID = table.Column<Guid>(nullable: false),
                    TransactionID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions_AdditionalInfo", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Transactions_AdditionalInfo_Transaction_TransactionID",
                        column: x => x.TransactionID,
                        principalTable: "Transaction",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Syndicate_Shares",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReplicationID = table.Column<Guid>(nullable: false),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedByStaffID = table.Column<int>(nullable: true),
                    SyndicateGameLinkID = table.Column<int>(nullable: false),
                    CustomerAccountID = table.Column<long>(nullable: false),
                    ShareCount = table.Column<int>(nullable: false),
                    NextShareCount = table.Column<int>(nullable: true),
                    LastBillingSuccess = table.Column<DateTime>(nullable: true),
                    IsClosed = table.Column<bool>(nullable: false),
                    PauseStartDate = table.Column<DateTime>(nullable: true),
                    PauseEndDate = table.Column<DateTime>(nullable: true),
                    PurchasedOn = table.Column<DateTime>(nullable: true),
                    CancellationRequestedOn = table.Column<DateTime>(nullable: true),
                    CancellationOccursOn = table.Column<DateTime>(nullable: true),
                    CancellationRequestTransactionID = table.Column<long>(nullable: true),
                    IsPromo = table.Column<bool>(nullable: false),
                    CancelAfterPooledCount = table.Column<int>(nullable: true),
                    CancellationFlagTransactionID = table.Column<long>(nullable: true),
                    Syndicate_Promo_LinkID = table.Column<int>(nullable: true),
                    OrderID = table.Column<long>(nullable: true),
                    NotifiedOn = table.Column<DateTime>(nullable: true),
                    Syndicate_Games_LinkID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Syndicate_Shares", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Syndicate_Shares_Syndicate_Games_Link_Syndicate_Games_LinkID",
                        column: x => x.Syndicate_Games_LinkID,
                        principalTable: "Syndicate_Games_Link",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Syndicate_Pools",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReplicationID = table.Column<Guid>(nullable: false),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    Syndicate_PeriodID = table.Column<long>(nullable: false),
                    IsClosed = table.Column<bool>(nullable: false),
                    Syndicate_PeriodsID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Syndicate_Pools", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Syndicate_Pools_Syndicate_Periods_Syndicate_PeriodsID",
                        column: x => x.Syndicate_PeriodsID,
                        principalTable: "Syndicate_Periods",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    ReplicationID = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedByStaffID = table.Column<int>(nullable: true),
                    AppliesToDateTime = table.Column<DateTime>(nullable: false),
                    Amount = table.Column<decimal>(nullable: true),
                    PreAmount = table.Column<decimal>(nullable: true),
                    PostAmount = table.Column<decimal>(nullable: true),
                    OrderSourceID = table.Column<int>(nullable: true),
                    GameTypeID = table.Column<int>(nullable: true),
                    LocationID = table.Column<int>(nullable: true),
                    StaffID = table.Column<int>(nullable: true),
                    ThirdPartyID = table.Column<int>(nullable: true),
                    TerminalID = table.Column<int>(nullable: true),
                    ForwardedToWallet = table.Column<bool>(nullable: true),
                    ForwardedSuccessOn = table.Column<DateTime>(nullable: true),
                    ForwardingFailCount = table.Column<int>(nullable: false),
                    ForwardedLastFailedOn = table.Column<DateTime>(nullable: true),
                    ForwardingIdentifier = table.Column<string>(nullable: true),
                    ExternalTransactionID = table.Column<long>(nullable: true),
                    CustomerBalanceID = table.Column<long>(nullable: true),
                    IsSystemVoid = table.Column<bool>(nullable: false),
                    RelatedToTransactionID = table.Column<long>(nullable: true),
                    IsNeedingReview = table.Column<bool>(nullable: false),
                    CustomerSessionID = table.Column<long>(nullable: true),
                    BankID = table.Column<int>(nullable: true),
                    DisbursementCategoryID = table.Column<int>(nullable: true),
                    ExternalGameID = table.Column<string>(nullable: true),
                    ExternalSessionID = table.Column<string>(nullable: true),
                    WalletApplicationID = table.Column<int>(nullable: true),
                    ExternalReferenceID = table.Column<string>(nullable: true),
                    IsCorrected = table.Column<bool>(nullable: false),
                    CorrectedByStaffID = table.Column<int>(nullable: true),
                    CorrectedOn = table.Column<DateTime>(nullable: true),
                    CorrectedTransactionID = table.Column<long>(nullable: true),
                    IsCorrection = table.Column<bool>(nullable: false),
                    CorrectionByStaffID = table.Column<int>(nullable: true),
                    CorrectionOn = table.Column<DateTime>(nullable: true),
                    CorrectionTransactionID = table.Column<long>(nullable: true),
                    StaffSessionID = table.Column<long>(nullable: true),
                    PromotionID = table.Column<int>(nullable: true),
                    PromotionSubID = table.Column<int>(nullable: true),
                    JackpotID = table.Column<short>(nullable: true),
                    ExternalRoundID = table.Column<string>(nullable: true),
                    ReviewedByStaffID = table.Column<int>(nullable: true),
                    ReviewedOn = table.Column<DateTime>(nullable: true),
                    DrawingID = table.Column<long>(nullable: true),
                    LimitID = table.Column<int>(nullable: true),
                    OrderDetails_Lottery_ID = table.Column<long>(nullable: true),
                    TaxRate = table.Column<decimal>(nullable: false),
                    CustomersID = table.Column<int>(nullable: true),
                    TransactionTypesID = table.Column<int>(nullable: true),
                    OrdersID = table.Column<long>(nullable: true),
                    Transactions_AdditionalInfoID = table.Column<long>(nullable: true),
                    OrderID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Transactions_Customers_CustomersID",
                        column: x => x.CustomersID,
                        principalTable: "Customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transactions_Order_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transactions_Orders_OrdersID",
                        column: x => x.OrdersID,
                        principalTable: "Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transactions_TransactionType_TransactionTypesID",
                        column: x => x.TransactionTypesID,
                        principalTable: "TransactionType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transactions_Transactions_AdditionalInfo_Transactions_AdditionalInfoID",
                        column: x => x.Transactions_AdditionalInfoID,
                        principalTable: "Transactions_AdditionalInfo",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Syndicate_Queue_Details",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReplicationID = table.Column<Guid>(nullable: false),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    Syndicate_QueueID = table.Column<long>(nullable: false),
                    Syndicate_ShareID = table.Column<long>(nullable: false),
                    ShareCount = table.Column<int>(nullable: false),
                    Syndicate_SharesID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Syndicate_Queue_Details", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Syndicate_Queue_Details_Syndicate_Queue_Syndicate_QueueID",
                        column: x => x.Syndicate_QueueID,
                        principalTable: "Syndicate_Queue",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Syndicate_Queue_Details_Syndicate_Shares_Syndicate_SharesID",
                        column: x => x.Syndicate_SharesID,
                        principalTable: "Syndicate_Shares",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Syndicate_Share_Numbers",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReplicationID = table.Column<Guid>(nullable: false),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedByStaffID = table.Column<int>(nullable: true),
                    Syndicate_ShareID = table.Column<long>(nullable: false),
                    B1 = table.Column<string>(nullable: true),
                    B2 = table.Column<string>(nullable: true),
                    B3 = table.Column<string>(nullable: true),
                    B4 = table.Column<string>(nullable: true),
                    B5 = table.Column<string>(nullable: true),
                    B6 = table.Column<string>(nullable: true),
                    B7 = table.Column<string>(nullable: true),
                    B8 = table.Column<string>(nullable: true),
                    B9 = table.Column<string>(nullable: true),
                    B10 = table.Column<string>(nullable: true),
                    B11 = table.Column<string>(nullable: true),
                    B12 = table.Column<string>(nullable: true),
                    B13 = table.Column<string>(nullable: true),
                    B14 = table.Column<string>(nullable: true),
                    B15 = table.Column<string>(nullable: true),
                    B16 = table.Column<string>(nullable: true),
                    B17 = table.Column<string>(nullable: true),
                    B18 = table.Column<string>(nullable: true),
                    B19 = table.Column<string>(nullable: true),
                    B20 = table.Column<string>(nullable: true),
                    SortedBallString = table.Column<string>(nullable: true),
                    Syndicate_SharesID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Syndicate_Share_Numbers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Syndicate_Share_Numbers_Syndicate_Shares_Syndicate_SharesID",
                        column: x => x.Syndicate_SharesID,
                        principalTable: "Syndicate_Shares",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Syndicate_Orders",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    ReplicationID = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    OrderID = table.Column<long>(nullable: false),
                    Syndicate_PoolID = table.Column<long>(nullable: false),
                    Syndicate_PoolsID = table.Column<long>(nullable: true),
                    OrdersID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Syndicate_Orders", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Syndicate_Orders_Order_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Syndicate_Orders_Orders_OrdersID",
                        column: x => x.OrdersID,
                        principalTable: "Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Syndicate_Orders_Syndicate_Pools_Syndicate_PoolsID",
                        column: x => x.Syndicate_PoolsID,
                        principalTable: "Syndicate_Pools",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Syndicate_Pool_Details",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReplicationID = table.Column<Guid>(nullable: false),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    Syndicate_PoolID = table.Column<long>(nullable: false),
                    Syndicate_QueueID = table.Column<long>(nullable: true),
                    CustomerNotifiedOn = table.Column<DateTime>(nullable: true),
                    Removed_Syndicate_QueueID = table.Column<long>(nullable: true),
                    RemovedOn = table.Column<DateTime>(nullable: true),
                    Syndicate_PoolsID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Syndicate_Pool_Details", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Syndicate_Pool_Details_Syndicate_Pools_Syndicate_PoolsID",
                        column: x => x.Syndicate_PoolsID,
                        principalTable: "Syndicate_Pools",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Syndicate_Pool_Details_Syndicate_Queue_Syndicate_QueueID",
                        column: x => x.Syndicate_QueueID,
                        principalTable: "Syndicate_Queue",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Syndicate_Pool_Numbers",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReplicationID = table.Column<Guid>(nullable: false),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    Syndicate_PoolID = table.Column<long>(nullable: false),
                    B1 = table.Column<string>(nullable: true),
                    B2 = table.Column<string>(nullable: true),
                    B3 = table.Column<string>(nullable: true),
                    B4 = table.Column<string>(nullable: true),
                    B5 = table.Column<string>(nullable: true),
                    B6 = table.Column<string>(nullable: true),
                    B7 = table.Column<string>(nullable: true),
                    B8 = table.Column<string>(nullable: true),
                    B9 = table.Column<string>(nullable: true),
                    B10 = table.Column<string>(nullable: true),
                    B11 = table.Column<string>(nullable: true),
                    B12 = table.Column<string>(nullable: true),
                    B13 = table.Column<string>(nullable: true),
                    B14 = table.Column<string>(nullable: true),
                    B15 = table.Column<string>(nullable: true),
                    B16 = table.Column<string>(nullable: true),
                    B17 = table.Column<string>(nullable: true),
                    B18 = table.Column<string>(nullable: true),
                    B19 = table.Column<string>(nullable: true),
                    B20 = table.Column<string>(nullable: true),
                    SortedBallString = table.Column<string>(nullable: true),
                    Syndicate_PoolsID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Syndicate_Pool_Numbers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Syndicate_Pool_Numbers_Syndicate_Pools_Syndicate_PoolsID",
                        column: x => x.Syndicate_PoolsID,
                        principalTable: "Syndicate_Pools",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Games_ProgressiveJackpots_Queue",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReplicationID = table.Column<Guid>(nullable: false),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    JackpotID = table.Column<short>(nullable: false),
                    DrawingID = table.Column<long>(nullable: false),
                    OrderID = table.Column<long>(nullable: true),
                    Amount = table.Column<decimal>(nullable: false),
                    TransactionID = table.Column<long>(nullable: true),
                    RelatedToTransactionID = table.Column<long>(nullable: true),
                    TransactionsID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games_ProgressiveJackpots_Queue", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Games_ProgressiveJackpots_Queue_Transaction_TransactionID",
                        column: x => x.TransactionID,
                        principalTable: "Transaction",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Games_ProgressiveJackpots_Queue_Transactions_TransactionsID",
                        column: x => x.TransactionsID,
                        principalTable: "Transactions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Syndicate_Queue_Numbers",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReplicationID = table.Column<Guid>(nullable: false),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    Syndicate_Queue_DetailsID = table.Column<long>(nullable: false),
                    B1 = table.Column<string>(nullable: true),
                    B2 = table.Column<string>(nullable: true),
                    B3 = table.Column<string>(nullable: true),
                    B4 = table.Column<string>(nullable: true),
                    B5 = table.Column<string>(nullable: true),
                    B6 = table.Column<string>(nullable: true),
                    B7 = table.Column<string>(nullable: true),
                    B8 = table.Column<string>(nullable: true),
                    B9 = table.Column<string>(nullable: true),
                    B10 = table.Column<string>(nullable: true),
                    B11 = table.Column<string>(nullable: true),
                    B12 = table.Column<string>(nullable: true),
                    B13 = table.Column<string>(nullable: true),
                    B14 = table.Column<string>(nullable: true),
                    B15 = table.Column<string>(nullable: true),
                    B16 = table.Column<string>(nullable: true),
                    B17 = table.Column<string>(nullable: true),
                    B18 = table.Column<string>(nullable: true),
                    B19 = table.Column<string>(nullable: true),
                    B20 = table.Column<string>(nullable: true),
                    SortedBallString = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Syndicate_Queue_Numbers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Syndicate_Queue_Numbers_Syndicate_Queue_Details_Syndicate_Queue_DetailsID",
                        column: x => x.Syndicate_Queue_DetailsID,
                        principalTable: "Syndicate_Queue_Details",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Syndicate_Pool_Payouts",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReplicationID = table.Column<Guid>(nullable: false),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    Syndicate_Order_ID = table.Column<long>(nullable: false),
                    Syndicate_QueueID = table.Column<long>(nullable: true),
                    PayoutTotal = table.Column<decimal>(nullable: true),
                    IsPaid = table.Column<bool>(nullable: false),
                    OrderDetails_Lottery_ID = table.Column<long>(nullable: false),
                    Released_Syndicate_QueueID = table.Column<long>(nullable: true),
                    ReleasedOn = table.Column<DateTime>(nullable: true),
                    ConversionRate = table.Column<decimal>(nullable: true),
                    NotifiedOn = table.Column<DateTime>(nullable: true),
                    Syndicate_OrdersID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Syndicate_Pool_Payouts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Syndicate_Pool_Payouts_Syndicate_Orders_Syndicate_OrdersID",
                        column: x => x.Syndicate_OrdersID,
                        principalTable: "Syndicate_Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Syndicate_Pool_Payouts_Syndicate_Queue_Syndicate_QueueID",
                        column: x => x.Syndicate_QueueID,
                        principalTable: "Syndicate_Queue",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Billing_Queue_Detail_CustomerAccountID",
                table: "Customer_Billing_Queue_Detail",
                column: "CustomerAccountID");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Billing_Queue_Detail_Customer_Billing_QueueID",
                table: "Customer_Billing_Queue_Detail",
                column: "Customer_Billing_QueueID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAccount_CustomerID1",
                table: "CustomerAccount",
                column: "CustomerID1");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAccount_LimitID",
                table: "CustomerAccount",
                column: "LimitID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAccounts_Exclusions_CustomerAccountID",
                table: "CustomerAccounts_Exclusions",
                column: "CustomerAccountID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerBalance_CustomerAccountID",
                table: "CustomerBalance",
                column: "CustomerAccountID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerBalance_CustomerBalanceTypeID",
                table: "CustomerBalance",
                column: "CustomerBalanceTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_FranchiseID",
                table: "Customers",
                column: "FranchiseID");

            migrationBuilder.CreateIndex(
                name: "IX_Drawing_FranchiseID",
                table: "Drawing",
                column: "FranchiseID");

            migrationBuilder.CreateIndex(
                name: "IX_Drawing_GameTypeID",
                table: "Drawing",
                column: "GameTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_FormFields_ConfigurationSettings_FranchiseID",
                table: "FormFields_ConfigurationSettings",
                column: "FranchiseID");

            migrationBuilder.CreateIndex(
                name: "IX_FormFields_ConfigurationSettings_GeneralDomainID",
                table: "FormFields_ConfigurationSettings",
                column: "GeneralDomainID");

            migrationBuilder.CreateIndex(
                name: "IX_Franchises_LimitID",
                table: "Franchises",
                column: "LimitID");

            migrationBuilder.CreateIndex(
                name: "IX_Games_Lottery_BallLimits_FranchiseID",
                table: "Games_Lottery_BallLimits",
                column: "FranchiseID");

            migrationBuilder.CreateIndex(
                name: "IX_Games_Lottery_BallLimits_Games_Lottery_GameTypesID",
                table: "Games_Lottery_BallLimits",
                column: "Games_Lottery_GameTypesID");

            migrationBuilder.CreateIndex(
                name: "IX_Games_Lottery_Drawings_DrawingID",
                table: "Games_Lottery_Drawings",
                column: "DrawingID");

            migrationBuilder.CreateIndex(
                name: "IX_Games_Lottery_Drawings_Games_Lottery_Drawings_GroupID",
                table: "Games_Lottery_Drawings",
                column: "Games_Lottery_Drawings_GroupID");

            migrationBuilder.CreateIndex(
                name: "IX_Games_Lottery_Drawings_Games_Lottery_GamesID",
                table: "Games_Lottery_Drawings",
                column: "Games_Lottery_GamesID");

            migrationBuilder.CreateIndex(
                name: "IX_Games_Lottery_Games_FranchiseID",
                table: "Games_Lottery_Games",
                column: "FranchiseID");

            migrationBuilder.CreateIndex(
                name: "IX_Games_Lottery_Games_Games_Lottery_GameTypesID",
                table: "Games_Lottery_Games",
                column: "Games_Lottery_GameTypesID");

            migrationBuilder.CreateIndex(
                name: "IX_Games_ProgressiveJackpots_Queue_TransactionID",
                table: "Games_ProgressiveJackpots_Queue",
                column: "TransactionID");

            migrationBuilder.CreateIndex(
                name: "IX_Games_ProgressiveJackpots_Queue_TransactionsID",
                table: "Games_ProgressiveJackpots_Queue",
                column: "TransactionsID");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralDomain_GeneralDomain2ID",
                table: "GeneralDomain",
                column: "GeneralDomain2ID");

            migrationBuilder.CreateIndex(
                name: "IX_LimitDetail_LimitID",
                table: "LimitDetail",
                column: "LimitID");

            migrationBuilder.CreateIndex(
                name: "IX_LimitDetail_LimitTypeID",
                table: "LimitDetail",
                column: "LimitTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Media_Code_Groups_FranchiseID",
                table: "Media_Code_Groups",
                column: "FranchiseID");

            migrationBuilder.CreateIndex(
                name: "IX_Media_Codes_FranchiseID",
                table: "Media_Codes",
                column: "FranchiseID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomersID",
                table: "Order",
                column: "CustomersID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_FranchiseID",
                table: "Order",
                column: "FranchiseID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderBundle_FranchiseID",
                table: "OrderBundle",
                column: "FranchiseID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderBundle_Detail_Games_Lottery_GamesID",
                table: "OrderBundle_Detail",
                column: "Games_Lottery_GamesID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderBundle_Detail_OrderBundleID",
                table: "OrderBundle_Detail",
                column: "OrderBundleID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderBundle_Detail_SyndicateID",
                table: "OrderBundle_Detail",
                column: "SyndicateID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_Lottery_DrawingID",
                table: "OrderDetails_Lottery",
                column: "DrawingID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_Lottery_OrderBundle_DetailID",
                table: "OrderDetails_Lottery",
                column: "OrderBundle_DetailID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_Lottery_OrderID",
                table: "OrderDetails_Lottery",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_Lottery_OrdersID",
                table: "OrderDetails_Lottery",
                column: "OrdersID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_Product_OrderBundle_DetailID",
                table: "OrderDetails_Product",
                column: "OrderBundle_DetailID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_Product_OrderID",
                table: "OrderDetails_Product",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_Product_SyndicateID",
                table: "OrderDetails_Product",
                column: "SyndicateID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_Product_TransactionID",
                table: "OrderDetails_Product",
                column: "TransactionID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomersID",
                table: "Orders",
                column: "CustomersID");

            migrationBuilder.CreateIndex(
                name: "IX_Promotion_Franchises_FranchiseID",
                table: "Promotion_Franchises",
                column: "FranchiseID");

            migrationBuilder.CreateIndex(
                name: "IX_Promotion_Franchises_PromotionID",
                table: "Promotion_Franchises",
                column: "PromotionID");

            migrationBuilder.CreateIndex(
                name: "IX_Promotions_EventBonusing_Events_CustomerBalanceTypeID",
                table: "Promotions_EventBonusing_Events",
                column: "CustomerBalanceTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Promotions_EventBonusing_Events_Promotions_EventBonusing_EventTypesID",
                table: "Promotions_EventBonusing_Events",
                column: "Promotions_EventBonusing_EventTypesID");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_FranchiseID",
                table: "Staff",
                column: "FranchiseID");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_Staff_JobsID",
                table: "Staff",
                column: "Staff_JobsID");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_Job_TransactionTypes_Staff_JobsID",
                table: "Staff_Job_TransactionTypes",
                column: "Staff_JobsID");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_Job_TransactionTypes_TransactionTypeID",
                table: "Staff_Job_TransactionTypes",
                column: "TransactionTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_Sessions_StaffID",
                table: "Staff_Sessions",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_Syndicate_FranchiseID",
                table: "Syndicate",
                column: "FranchiseID");

            migrationBuilder.CreateIndex(
                name: "IX_Syndicate_Games_FranchiseID",
                table: "Syndicate_Games",
                column: "FranchiseID");

            migrationBuilder.CreateIndex(
                name: "IX_Syndicate_Games_Games_Lottery_GamesID",
                table: "Syndicate_Games",
                column: "Games_Lottery_GamesID");

            migrationBuilder.CreateIndex(
                name: "IX_Syndicate_Games_Link_SyndicateID",
                table: "Syndicate_Games_Link",
                column: "SyndicateID");

            migrationBuilder.CreateIndex(
                name: "IX_Syndicate_Games_Link_Syndicate_GamesID",
                table: "Syndicate_Games_Link",
                column: "Syndicate_GamesID");

            migrationBuilder.CreateIndex(
                name: "IX_Syndicate_MediaCodes_Media_CodesID",
                table: "Syndicate_MediaCodes",
                column: "Media_CodesID");

            migrationBuilder.CreateIndex(
                name: "IX_Syndicate_MediaCodes_SyndicateID",
                table: "Syndicate_MediaCodes",
                column: "SyndicateID");

            migrationBuilder.CreateIndex(
                name: "IX_Syndicate_Orders_OrderID",
                table: "Syndicate_Orders",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Syndicate_Orders_OrdersID",
                table: "Syndicate_Orders",
                column: "OrdersID");

            migrationBuilder.CreateIndex(
                name: "IX_Syndicate_Orders_Syndicate_PoolsID",
                table: "Syndicate_Orders",
                column: "Syndicate_PoolsID");

            migrationBuilder.CreateIndex(
                name: "IX_Syndicate_Periods_Syndicate_GamesID",
                table: "Syndicate_Periods",
                column: "Syndicate_GamesID");

            migrationBuilder.CreateIndex(
                name: "IX_Syndicate_Pool_Details_Syndicate_PoolsID",
                table: "Syndicate_Pool_Details",
                column: "Syndicate_PoolsID");

            migrationBuilder.CreateIndex(
                name: "IX_Syndicate_Pool_Details_Syndicate_QueueID",
                table: "Syndicate_Pool_Details",
                column: "Syndicate_QueueID");

            migrationBuilder.CreateIndex(
                name: "IX_Syndicate_Pool_Numbers_Syndicate_PoolsID",
                table: "Syndicate_Pool_Numbers",
                column: "Syndicate_PoolsID");

            migrationBuilder.CreateIndex(
                name: "IX_Syndicate_Pool_Payouts_Syndicate_OrdersID",
                table: "Syndicate_Pool_Payouts",
                column: "Syndicate_OrdersID");

            migrationBuilder.CreateIndex(
                name: "IX_Syndicate_Pool_Payouts_Syndicate_QueueID",
                table: "Syndicate_Pool_Payouts",
                column: "Syndicate_QueueID");

            migrationBuilder.CreateIndex(
                name: "IX_Syndicate_Pools_Syndicate_PeriodsID",
                table: "Syndicate_Pools",
                column: "Syndicate_PeriodsID");

            migrationBuilder.CreateIndex(
                name: "IX_Syndicate_Queue_Details_Syndicate_QueueID",
                table: "Syndicate_Queue_Details",
                column: "Syndicate_QueueID");

            migrationBuilder.CreateIndex(
                name: "IX_Syndicate_Queue_Details_Syndicate_SharesID",
                table: "Syndicate_Queue_Details",
                column: "Syndicate_SharesID");

            migrationBuilder.CreateIndex(
                name: "IX_Syndicate_Queue_Numbers_Syndicate_Queue_DetailsID",
                table: "Syndicate_Queue_Numbers",
                column: "Syndicate_Queue_DetailsID");

            migrationBuilder.CreateIndex(
                name: "IX_Syndicate_Share_Numbers_Syndicate_SharesID",
                table: "Syndicate_Share_Numbers",
                column: "Syndicate_SharesID");

            migrationBuilder.CreateIndex(
                name: "IX_Syndicate_Shares_Syndicate_Games_LinkID",
                table: "Syndicate_Shares",
                column: "Syndicate_Games_LinkID");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_CustomerID1",
                table: "Transaction",
                column: "CustomerID1");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_FranchiseID",
                table: "Transaction",
                column: "FranchiseID");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_OrderID",
                table: "Transaction",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_TransactionTypeID",
                table: "Transaction",
                column: "TransactionTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_CustomersID",
                table: "Transactions",
                column: "CustomersID");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_OrderID",
                table: "Transactions",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_OrdersID",
                table: "Transactions",
                column: "OrdersID");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_TransactionTypesID",
                table: "Transactions",
                column: "TransactionTypesID");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_Transactions_AdditionalInfoID",
                table: "Transactions",
                column: "Transactions_AdditionalInfoID");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_AdditionalInfo_TransactionID",
                table: "Transactions_AdditionalInfo",
                column: "TransactionID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer_Billing_Queue_Detail");

            migrationBuilder.DropTable(
                name: "CustomerAccounts_Exclusions");

            migrationBuilder.DropTable(
                name: "CustomerBalance");

            migrationBuilder.DropTable(
                name: "FormFields_ConfigurationSettings");

            migrationBuilder.DropTable(
                name: "Games_Lottery_BallLimits");

            migrationBuilder.DropTable(
                name: "Games_Lottery_Drawings");

            migrationBuilder.DropTable(
                name: "Games_ProgressiveJackpots_Queue");

            migrationBuilder.DropTable(
                name: "LimitDetail");

            migrationBuilder.DropTable(
                name: "Media_Code_Groups");

            migrationBuilder.DropTable(
                name: "OrderDetails_Lottery");

            migrationBuilder.DropTable(
                name: "OrderDetails_Product");

            migrationBuilder.DropTable(
                name: "Promotion_Franchises");

            migrationBuilder.DropTable(
                name: "Promotions_EventBonusing_Events");

            migrationBuilder.DropTable(
                name: "Staff_Job_TransactionTypes");

            migrationBuilder.DropTable(
                name: "Staff_Sessions");

            migrationBuilder.DropTable(
                name: "Syndicate_MediaCodes");

            migrationBuilder.DropTable(
                name: "Syndicate_Pool_Details");

            migrationBuilder.DropTable(
                name: "Syndicate_Pool_Numbers");

            migrationBuilder.DropTable(
                name: "Syndicate_Pool_Payouts");

            migrationBuilder.DropTable(
                name: "Syndicate_Queue_Numbers");

            migrationBuilder.DropTable(
                name: "Syndicate_Share_Numbers");

            migrationBuilder.DropTable(
                name: "Customer_Billing_Queue");

            migrationBuilder.DropTable(
                name: "CustomerAccount");

            migrationBuilder.DropTable(
                name: "GeneralDomain");

            migrationBuilder.DropTable(
                name: "Games_Lottery_Drawings_Group");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "LimitType");

            migrationBuilder.DropTable(
                name: "Drawing");

            migrationBuilder.DropTable(
                name: "OrderBundle_Detail");

            migrationBuilder.DropTable(
                name: "Promotion");

            migrationBuilder.DropTable(
                name: "CustomerBalanceType");

            migrationBuilder.DropTable(
                name: "Promotions_EventBonusing_EventTypes");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "Media_Codes");

            migrationBuilder.DropTable(
                name: "Syndicate_Orders");

            migrationBuilder.DropTable(
                name: "Syndicate_Queue_Details");

            migrationBuilder.DropTable(
                name: "Transactions_AdditionalInfo");

            migrationBuilder.DropTable(
                name: "GameType");

            migrationBuilder.DropTable(
                name: "OrderBundle");

            migrationBuilder.DropTable(
                name: "Staff_Jobs");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Syndicate_Pools");

            migrationBuilder.DropTable(
                name: "Syndicate_Queue");

            migrationBuilder.DropTable(
                name: "Syndicate_Shares");

            migrationBuilder.DropTable(
                name: "Transaction");

            migrationBuilder.DropTable(
                name: "Syndicate_Periods");

            migrationBuilder.DropTable(
                name: "Syndicate_Games_Link");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "TransactionType");

            migrationBuilder.DropTable(
                name: "Syndicate");

            migrationBuilder.DropTable(
                name: "Syndicate_Games");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Games_Lottery_Games");

            migrationBuilder.DropTable(
                name: "Franchises");

            migrationBuilder.DropTable(
                name: "Games_Lottery_GameTypes");

            migrationBuilder.DropTable(
                name: "Limit");
        }
    }
}
