using System;
using SpaBingo.Entities.Lottery;
using Microsoft.AspNetCore.Mvc;
using SpaBingo.Helpers;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpaBingo.Controllers
{
    [Route("api/[controller]")]
    public class LotteryController : Controller
    {
        //private DataContext _context;
        private LotteryContext _context;
        public LotteryController(LotteryContext context)
        {
            _context = context;
        }

        public sealed class PlayerInfo
        {
            public string Token { get; set; }
            public string LotteryToken { get; set; }
            public long PlayerID { get; set; }
            public long PlayerAccountID { get; set; }
            public string PlayerAccountGUID { get; set; }
            public long? PlayerSessionID { get; set; }
            public string Username { get; set; }
            public decimal Balance { get; set; }
            public bool IsActive { get; set; }
            public bool IsLocked { get; set; }
            public bool IsExcluded { get; set; }
            public string CurrencyCulture { get; set; }
        }
        public abstract class BaseResponse
        {
            public BaseResponse()
            {
                ServerTimeLocal = DateTime.Now.ToString();
                ServerTimeUTC = DateTime.UtcNow.ToString();
                WasSuccessful = false;
                Message = null;
            }

            public string ServerTimeLocal { get; set; }
            public string ServerTimeUTC { get; set; }
            public bool WasSuccessful { get; set; }
            public string Message { get; set; }
            public string Token { get; set; }
        }
        public abstract class BaseRequest
        {
            /// <summary>
            /// Validates the response.
            /// Returns false if the callee should throw a bad request message.
            /// </summary>
            /// <returns></returns>
            public virtual bool ValidateRequest()
            {
                var ok = Key != Guid.Empty;
                return ok;
            }

            public Guid Key { get; set; }
            public string Culture { get; set; }
            public string Token { get; set; }
            public bool TestMode { get; set; }
        }
        class GeneralErrors
        {
            ///// <summary>
            ///// Bad request - missing or invalid parameters most likely cause. Check docs and try again.
            ///// </summary>
            //public const string BAD_REQUEST = "BAD_REQUEST";

            /// <summary>
            /// Player token passed in is either null or blank. Gameplay cannot continue.
            /// </summary>
            public const string PLAYER_TOKEN_NULL = "PLAYER_TOKEN_NULL";

            /// <summary>
            /// Player referenced with token was not found. Gameplay cannot continue.
            /// </summary>
            public const string PLAYER_NOT_FOUND = "PLAYER_NOT_FOUND";

            /// <summary>
            /// The player has been excluded from play, either system or self exclusion applies here.
            /// Show a friendly message stating such and quit.
            /// </summary>
            public const string PLAYER_EXCLUDED_FROM_PLAY = "PLAYER_EXCLUDED_FROM_PLAY";

            /// <summary>
            /// Player has been locked out of account due to too many failed password attempts.
            /// </summary>
            public const string PLAYER_LOCKED_OUT = "PLAYER_LOCKED_OUT";

            /// <summary>
            /// Player is not locked out, excluded but is still inactive, possibly due to inacitvity.
            /// </summary>
            public const string PLAYER_INACTIVE = "PLAYER_INACTIVE";

            /// <summary>
            /// Players session is closed, possibly due to inactivity.
            /// </summary>
            public const string PLAYER_SESSION_CLOSED = "PLAYER_SESSION_CLOSED";

            /// <summary>
            /// Key specified doesn't exist.
            /// </summary>
            public const string INVALID_KEY = "INVALID_KEY";

            /// <summary>
            /// Game or Syndicate Game not found
            /// </summary>
            public const string GAME_NOT_FOUND = "GAME_NOT_FOUND";

            /// <summary>
            /// Gaming is not available at this time;
            /// </summary>
            public const string GAMING_UNAVAILABLE = "GAMING_UNAVAILABLE";
        }
        private PlayerInfo PlayerInfoFromToken(string token, int walletApplicationID = 1)
        {
            return PlayerInfoFromToken(token, walletApplicationID);
        }

        public sealed class GetPlayerInfoRequest : BaseRequest
        {
            public override bool ValidateRequest()
            {
                var ok = !string.IsNullOrWhiteSpace(Token);
                if (!ok)
                    return ok;
                return base.ValidateRequest();
            }
        }

        public sealed class GetPlayerInfoResponse : BaseResponse
        {
            public GetPlayerInfoResponse() : base() { }
            public GetPlayerInfoResponse(string error)
                : base()
            {
                WasSuccessful = false;
                Message = error;
            }

            public PlayerInfo Player { get; set; }
        }
        private string CheckPlayerStatus(PlayerInfo player)
        {
            if (player == null)
            {
                return GeneralErrors.PLAYER_NOT_FOUND;
            }
            if (!player.PlayerSessionID.HasValue)
            {
                return GeneralErrors.PLAYER_SESSION_CLOSED;
            }
            if (!player.IsActive)
            {
                return GeneralErrors.PLAYER_INACTIVE;
            }
            if (player.IsLocked)
            {
                return GeneralErrors.PLAYER_LOCKED_OUT;
            }
            if (player.IsExcluded)
            {
                return GeneralErrors.PLAYER_EXCLUDED_FROM_PLAY;
            }

            return "";
        }
        public sealed class GetFranchiseInfoRequest : BaseRequest
        {
            public bool BypassCache { get; set; }
        }
        public sealed class GetFranchiseInfoResponse : BaseResponse
        {
            public GetFranchiseInfoResponse() { }
            public GetFranchiseInfoResponse(string error)             {
                WasSuccessful = false;
                Message = error;
            }
        }
        #region Data Calls

        /// <summary>
        /// Gets franchise info from key. Returns null if franchise is not found.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        //private Franchise FranchiseFromKey(Guid key)
        //{
        //    var db = LotteryDB
        //    return FranchiseFromKey(db, key);
        //}

        /// <summary>
        /// Gets franchise info from key using an existing database connection. Returns null if franchise is not found.
        /// </summary>
        /// <param name="db"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        private Franchise FranchiseFromKey(LotteryContext db, Guid key)
        {
            return db.Franchises.SingleOrDefault(f => f.ReplicationID == key);
        }
        /// <summary>
        /// Grab the Franchise register based on the key sent
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        //[HttpPost]
        //public IActionResult GetFranchiseInfo(GetFranchiseInfoRequest request)
        //{

        //    if (request == null || !request.ValidateRequest())
        //        return BadRequest();
        //    FranchiseInfoResult franchiseInfoRequest = GetFranchiseInfoFromKey(request.Key);

        //    if (franchiseInfoRequest == null)
        //    {
        //        return Ok(new GetFranchiseInfoResponse(GetDrawingsErrors.INVALID_KEY));
        //    }
        //    var customerHelper = new Customers.AccountManager();
        //    List<FormFields_ConfigurationSettings> config = customerHelper.GetConfigurationFieldsByForm(franchiseInfoRequest.ID, 2); // add configuration for form ID: 2 = signup, 3 = my profile.
        //    return Ok(new GetFranchiseInfoResponse(franchiseInfoRequest, config));
        //}
        public FranchiseInfoResult GetFranchiseInfoFromKey(Guid key)
        {
            {
                var franchise = _context.Franchises.Where(f => f.ReplicationID == key).SingleOrDefault();
                if (franchise == null)
                    return null;
                return new FranchiseInfoResult()
                {
                    ID = franchise.ID,
                    FranchiseGUID = franchise.ReplicationID,
                    IsActive = franchise.IsActive,
                    Name = franchise.Name,
                    CurrencyCulture = franchise.CurrencyCulture,
                    CardSwipeRequired = franchise.IsSwipeRequired,
                    OrderValidDays = franchise.OrderValidDays,
                    ATMCardParsingRegex = franchise.ATMCardParsingRegex,
                    AllowFractionalBets = franchise.AllowFractionalBets,
                    Denominations = franchise.Denominations,
                    CurrencyCode = franchise.Wallet_Currency

                };
            }
        }
        // GET: /<controller>/
        [HttpPost]
        public IActionResult GetPlayerInfo(GetPlayerInfoRequest request)
        {
            if (request == null || !request.ValidateRequest())
                return BadRequest();

            if (request.TestMode == true)
            {
                return Ok(new GetPlayerInfoResponse()
                {
                    WasSuccessful = true,
                    Player = new PlayerInfo()
                    {
                        Balance = 123.45M,
                        CurrencyCulture = "USD",
                        IsActive = true,
                        IsExcluded = false,
                        IsLocked = false,
                        LotteryToken = Guid.NewGuid().ToString(),
                        PlayerAccountGUID = "54BDBCD4-227D-4D96-AFD4-3A07CEA933FA",
                        PlayerAccountID = 12345,
                        PlayerID = 12345,
                        PlayerSessionID = 1234567,
                        Token = Guid.NewGuid().ToString(),
                        Username = "tester123"
                    }
                });
            }
            else
            {
                var db = _context;
                {
                    var franchise = FranchiseFromKey(db, request.Key);
                    if (franchise == null)
                        return Ok(new GetPlayerInfoResponse(GeneralErrors.PLAYER_NOT_FOUND));

                    var player = PlayerInfoFromToken(request.Token);
                    if (player == null)
                        return Ok(new GetPlayerInfoResponse(GeneralErrors.PLAYER_NOT_FOUND));

                    // Player must be logged in and valid to place an order;
                    string status = CheckPlayerStatus(player);
                    if (!string.IsNullOrWhiteSpace(status))
                        return Ok(new GetPlayerInfoResponse(status));

                    //We're just checking is the player is allowed to play.
                    //FranchiseInfoResult franchiseInfoRequest = GetFranchiseInfoFromKey(request.Key);
                    //using (Lotto.Orders.WebOrderTakerModel.WebOrderTakerModel LotteryOrderTaker = new MCS.Lottery.Lotto.Orders.WebOrderTakerModel.WebOrderTakerModel(franchiseInfoRequest, player.PlayerAccountGUID, TokenType.UserID, /*null,*/ ip, hostName, 1, null))
                    //{
                    //    var wprovider = LotteryOrderTaker.GetWalletProvider();
                    //    if (wprovider.IsError)
                    //        return Ok(new GetPlayerInfoResponse(wprovider.Message));
                    //    if (!wprovider.CustomerVerified(LotteryOrderTaker.Wallet.InternalID))
                    //        return Ok(new GetPlayerInfoResponse(wprovider.Message));

                        return Ok(new GetPlayerInfoResponse()
                        {
                            WasSuccessful = true,
                            Player = player,
                        });
                   // }
                }
            }
        }
        #endregion Data Calls
        #region IDFK EITHER JSON OR MAYBE SP's?
        [DataContract]
        public class FranchiseConfigurationSettings_Wallet
        {
            [DataMember]
            public bool NewCustomer_IsExemptFromDocumentVerification { get; set; }
            [DataMember]
            public bool NewCustomer_IsTermsExplained { get; set; }
            [DataMember]
            public bool NewCustomer_IsExemptFromLocationChecks { get; set; }
            [DataMember]
            public bool NewCustomer_CanMakeDeposits { get; set; }
            [DataMember]
            public bool NewCustomer_CanMakeWithdraws { get; set; }
        }

        [DataContract]
        public class CustomerAccountVariableRequirements
        {
            [DataMember]
            public int FranchiseID { get; set; }
            [DataMember]
            public bool Required_Email { get; set; }
            [DataMember]
            public bool Required_PhoneNumber { get; set; }
            [DataMember]
            public bool Required_CellPhone { get; set; }
            [DataMember]
            public int? Required_Phone_MinLength { get; set; }
            [DataMember]
            public bool Required_PIN { get; set; }
            [DataMember]
            public bool Required_Address1 { get; set; }
            [DataMember]
            public bool Required_Address2 { get; set; }
            [DataMember]
            public bool Required_Address3 { get; set; }
            [DataMember]
            public bool Required_Address4 { get; set; }
            [DataMember]
            public bool Required_Locality { get; set; }
            [DataMember]
            public bool Required_Region { get; set; }
            [DataMember]
            public bool Required_PostCode { get; set; }
            [DataMember]
            public bool Required_Country { get; set; }
            [DataMember]
            public bool Required_Employer { get; set; }
            [DataMember]
            public bool Required_Birthday { get; set; }
            [DataMember]
            public int? Required_Birthday_Age { get; set; }
            [DataMember]
            public bool Required_Gender { get; set; }
            [DataMember]
            public bool Require_Unique_CellPhone { get; set; }
        }

        //namespace MCS.Lottery.Contracts
        //    {
        [DataContract]
        public class FranchiseInfoResult
        {
            [DataMember]
            public Guid FranchiseGUID { get; set; }
            [DataMember]
            public int ID { get; set; }
            [DataMember]
            public string Name { get; set; }
            [DataMember]
            public bool IsActive { get; set; }
            [DataMember]
            public string CurrencyCulture { get; set; }

            [DataMember]
            public string CurrencyCode { get; set; }
            [DataMember]
            public FranchiseInfoResult DepositWithdrawFranchiseInfo { get; set; }
            [DataMember]
            public bool CanMakeCustomerDeposits { get; set; }
            [DataMember]
            public bool CanMakeCustomerWithdraws { get; set; }
            [DataMember]
            public bool CardSwipeRequired { get; set; }
            [DataMember]
            public string WalletType { get; set; }
            [DataMember]
            public int? OrderValidDays { get; set; }
            [DataMember]
            public string ATMCardParsingRegex { get; set; }
            [DataMember]
            public bool UsesProvideChange { get; set; }
            [DataMember]
            public bool AllowFractionalBets { get; set; }
            [DataMember]
            public string Denominations { get; set; }
            [DataMember]
            public FranchiseConfigurationSettings_Wallet WalletConfigSettings { get; set; }
            [DataMember]
            public CustomerAccountVariableRequirements CustomerValidationRequirements { get; set; }
        }
        [DataContract]
        public class FormFields_ConfigurationSettings
        {
            [DataMember]
            public int ID { get; set; }
            [DataMember]
            public int FormID { get; set; }
            [DataMember]
            public int FranchiseID { get; set; }
            [DataMember]
            public string FieldName { get; set; }
            [DataMember]
            public bool IsRequired { get; set; }
            [DataMember]
            public bool IsDisplayed { get; set; }
            [DataMember]
            public string ExtraInfo { get; set; }
            [DataMember]
            public bool IsUnique { get; set; }

        }

        [DataContract]
        public class GeneralDomain
        {
            [DataMember]
            public int ID { get; set; }
            [DataMember]
            public string Name { get; set; }
            [DataMember]
            public string Code { get; set; }

        }

        [DataContract]
        public sealed class CustomerAccountDetails
        {
            public Guid Guid;
            [DataMember]
            public string Gender { get; set; }
            [DataMember]
            public DateTime? Birthday { get; set; }
            [DataMember]
            public string FirstName { get; set; }
            [DataMember]
            public string LastName { get; set; }
            [DataMember]
            public string Suffix { get; set; }
            [DataMember]
            public string Prefix { get; set; }
            [DataMember]
            public string EmailAddress { get; set; }
            [DataMember]
            public bool EmailAddressVerified { get; set; }
            [DataMember]
            public string PhoneNumber { get; set; }
            [DataMember]
            public bool PhoneNumberVerified { get; set; }

            [DataMember]
            public bool IsDocumentationVerified { get; set; }
            [DataMember]
            public bool IsExemptFromDocumentVerification { get; set; }

            //public string CardID { get; set; }
            [DataMember]
            public string CellPhone { get; set; }
            [DataMember]
            public bool CellPhoneVerified { get; set; }
            [DataMember]
            public string AddressLine1 { get; set; }
            [DataMember]
            public string AddressLine2 { get; set; }
            [DataMember]
            public string AddressLine3 { get; set; }
            [DataMember]
            public string AddressLine4 { get; set; }
            [DataMember]
            public string Locality { get; set; }
            [DataMember]
            public string Region { get; set; }
            [DataMember]
            public string Postcode { get; set; }
            [DataMember]
            public string Country { get; set; }
            [DataMember]
            public string Employer { get; set; }
            [DataMember]
            public bool AddressVerified { get; set; }

            [DataMember]
            public BalanceInfo[] Balances { get; set; }
            [DataMember]
            public bool OptIn_Important { get; set; }
            [DataMember]
            public bool OptIn_Marketing { get; set; }
            [DataMember]
            public bool IsOTPSetup { get; internal set; }

            //Billing
            [DataMember]
            public string MerchantAccountID { get; set; }
            [DataMember]
            public string AccountNumber { get; set; }
            [DataMember]
            public string ExpirationMonth { get; set; }
            [DataMember]
            public string ExpirationYear { get; set; }
            [DataMember]
            public string CardType { get; set; }
            [DataMember]
            public string CardSecurityCode { get; set; }
            [DataMember]
            public string PaymentMethodType { get; set; }
            [DataMember]
            public string SortCode { get; set; }
            [DataMember]
            public string BillingToken { get; set; }

            //Documents
            // TODO: TLS - Verify if we really need this
            // public MCS.Lottery.Wallets.MCS.Documents.Data.Document Picture { get; set; }
        }

        [DataContract]
        public sealed class BalanceInfo
        {
            [DataMember]
            public long ID { get; set; }
            [DataMember]
            public int BalanceTypeID { get; set; }
            [DataMember]
            public string Name { get; set; }
            [DataMember]
            public decimal? Amount { get; set; }
            [DataMember]
            public int? DisplayOrder { get; set; }
            [DataMember]
            public string Alias { get; set; }
            [DataMember]
            public string Description { get; set; }
        }

        [DataContract]
        //Franchise_ConfigurationSettings_Wallet_RequiredCustomerAccountFields
        public class Wallet_RequiredCustomerAccountFields
        {
            [DataMember]
            public int FranchiseID { get; set; }
            [DataMember]
            public Guid ReplicationID { get; set; }
            [DataMember]
            public byte[] Timestamp { get; set; }
            [DataMember]
            public bool Required_Email { get; set; }
            [DataMember]
            public bool Required_PhoneNumber { get; set; }
            [DataMember]
            public bool Required_CellPhone { get; set; }
            [DataMember]
            public Nullable<int> Required_Phone_MinLength { get; set; }
            [DataMember]
            public bool Required_PIN { get; set; }
            [DataMember]
            public bool Required_Address1 { get; set; }
            [DataMember]
            public bool Required_Locality { get; set; }
            [DataMember]
            public bool Required_Region { get; set; }
            [DataMember]
            public bool Required_PostCode { get; set; }
            [DataMember]
            public bool Required_Country { get; set; }
            [DataMember]
            public bool Required_Employer { get; set; }
            [DataMember]
            public bool Required_Birthday { get; set; }
            [DataMember]
            public int? Required_Birthday_Age { get; set; }
            [DataMember]
            public bool Required_Gender { get; set; }
            [DataMember]
            public bool Required_Validation_Email { get; set; }
            [DataMember]
            public bool Required_Validation_CellPhone { get; set; }
            [DataMember]
            public int Required_Validation_ExpirationMinutes { get; set; }
            [DataMember]
            public bool AllowDepositsForUnverifiedAccounts { get; set; }
            [DataMember]
            public bool AllowWithdrawsForUnverifiedAccounts { get; set; }
            [DataMember]
            public bool Required_Address2 { get; set; }
            [DataMember]
            public bool Required_Address3 { get; set; }
            [DataMember]
            public bool Required_Address4 { get; set; }
            [DataMember]
            public bool Displayed_Address1 { get; set; }
            [DataMember]
            public bool Displayed_Address2 { get; set; }
            [DataMember]
            public bool Displayed_Address3 { get; set; }
            [DataMember]
            public bool Displayed_Address4 { get; set; }
            [DataMember]
            public bool Displayed_Locality { get; set; }
            [DataMember]
            public bool Displayed_Region { get; set; }
            [DataMember]
            public bool Displayed_PostCode { get; set; }
            [DataMember]
            public bool Displayed_Country { get; set; }
            [DataMember]
            public string Address1Name { get; set; }
            [DataMember]
            public string Address2Name { get; set; }
            [DataMember]
            public string Address3Name { get; set; }
            [DataMember]
            public string Address4Name { get; set; }
            [DataMember]
            public string LocalityName { get; set; }
            [DataMember]
            public string RegionName { get; set; }
            [DataMember]
            public string PostcodeName { get; set; }
            [DataMember]
            public bool Require_Unique_CellPhone { get; set; }
        }

        [DataContract]
        public class Ticket
        {
            [DataMember]
            public long ID { get; set; }
            [DataMember]
            public DateTime? CreatedOn { get; set; }
            [DataMember]
            public Nullable<System.DateTime> DrawingDT { get; set; }
            [DataMember]
            public string GameName { get; set; }
            [DataMember]
            public string GameAbbreviation { get; set; }
            [DataMember]
            public string TicketURL { get; set; }
            [DataMember]
            public decimal? WinningAmount { get; set; }
            [DataMember]
            public decimal? Price { get; set; }
            [DataMember]
            public Nullable<long> OrderID { get; set; }
            [DataMember]
            public Nullable<long> TicketNumber { get; set; }
            [DataMember]
            public string SortedBallString { get; set; }
            [DataMember]
            public string UnsortedBallString { get; set; }
            [DataMember]
            public string SortedWinningBallString { get; set; }
            [DataMember]
            public string UnsortedWinningBallString { get; set; }
            [DataMember]
            public string OrderedOnBehalfOfFullName { get; set; }
            [DataMember]
            public string OrderedOnBehalfOfCellNumber { get; set; }
            [DataMember]
            public string GameImageURL { get; set; }
        }

        [DataContract]
        public class Order
        {
            [DataMember]
            public long OrderID { get; set; }
            [DataMember]
            public DateTime? CreatedOn { get; set; }
            [DataMember]
            public decimal? Price { get; set; }
            [DataMember]
            public Ticket[] Tickets { get; set; }
            [DataMember]
            public Bundle[] Bundles { get; set; }
            [DataMember]
            public Syndicate[] Syndicates { get; set; }
        }



        [DataContract]
        public class Syndicate
        {
            [DataMember]
            public int SyndicateID { get; set; }
            [DataMember]
            public string Name { get; set; }
            [DataMember]
            public decimal? Price { get; set; }
            //[DataMember]
            //public List<Orders.GameData> GamesData { get; set; }
        }


        public class Share
        {
            [DataMember]
            public String Game { get; set; }
            [DataMember]
            public List<string[]> numbers { get; set; }
        }

        [DataContract]
        public class Bundle
        {
            [DataMember]
            public int? BundleID { get; set; }
            [DataMember]
            public string Name { get; set; }
            [DataMember]
            public decimal? Price { get; set; }
            [DataMember]
            public Ticket[] Tickets { get; set; }
            [DataMember]
            public Syndicate[] Syndicates { get; set; }
        }
    }

    #endregion
}