using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using MCS.Lottery.Contracts;
//using MCS.Lottery.Contracts.Orders;
//using MCS.Lottery.Contracts.ProgressiveJackpots;
//using MCS.Lottery.Contracts.Wallet;
//using MCS.Lottery.Data;
//using MCS.Lottery.Localization;
//using MCS.Lottery.Logging;
//using MCS.Lottery.Lotto.PlaceOrder;
//using MCS.Auditing;

namespace MCS.Lottery.Lotto.Orders.WebOrderTakerModel
{
	public class WebOrderTakerModel : MCS.Lottery.Lotto.Orders.OrderTakerModel, IDisposable
	{
		//Public Variables
//		public CustomerWallet Wallet { get; private set; }
		public string IPAddress { get; set; }
		public string HostName { get; set; }
		public long CustomerFavoriteID { get; set; }
        //public long? CustomerSessionID
        //{
        //	get { return custSessionID; }
        //	set
        //	{
        //		if (custSessionID != value)
        //		{
        //			custSessionID = value;
        //			walletProvider.CustomerSessionID = value;
        //		}
        //	}
        //}
        //public DateTime LastSeenOn { get; set; }
        ////public MCS.Lottery.Contracts.Orders.ValidateOrderBetResult[] BetIssues { get { return invalidBets.ToArray(); } }
        //////Games Variables
        ////public List<MCS.Lottery.Contracts.Orders.LotteryGame> Games { get; set; }
        ////public MCS.Lottery.Contracts.Orders.LotteryGame CurrentGame { get; set; }
        ////public Games_Lottery_HouseImages_Result[] HouseImages
        //{
        //	get
        //	{
        //		return houseImages;
        //	}
        //}
        //public string GameName
        //{
        //	get
        //	{
        //		return GetGameName();
        //	}
        //}
        //public string NextClosingHouse
        //{
        //	get
        //	{
        //		TimeSpan ts;
        //		switch (GameTypeID)
        //		{
        //			case 1:
        //				var game = Games
        //					.SelectMany(h => h.Drawings)
        //					.Where(g => g.IsActive == true && g.IsDisplayed == true && g.CloseDT > DateTime.UtcNow)
        //					.OrderBy(g => g.CloseDT)
        //					.FirstOrDefault();
        //				if (game == null)
        //					return "";
        //				else
        //				{
        //					ts = game.CloseDT.Value.Subtract(DateTime.UtcNow);
        //					return string.Format(LocalizedResources.OrderTaker_01ClosesIn2Hours3Minutes, game.LotteryGameTypeID, game.LotteryGameTypeName, ts.Hours, ts.Minutes)
        //						.Replace(" 0 hours", "")
        //						.Replace(" 0 minutes", "")
        //						.Replace(" 1 hours", " 1 hour")
        //						.Replace(" 1 minutes", " 1 minute");
        //				}
        //			case 2:
        //			case 3:
        //				if (CurrentGame == null)
        //					return "No game is selected.";
        //				if (CurrentDrawing == null || CurrentDrawing.CloseDT.Value <= DateTime.UtcNow)
        //					LoadCurrentDrawing();
        //				if (CurrentDrawing == null)
        //					return "No drawings are active for this game.";
        //				ts = CurrentDrawing.CloseDT.Value.Subtract(DateTime.UtcNow);
        //				return string.Format("Drawing closes in {0} hours {1} minutes", ts.Hours, ts.Minutes)
        //					.Replace(" 0 hours", "")
        //					.Replace(" 0 minutes", "")
        //					.Replace(" 1 hours", " 1 hour")
        //					.Replace(" 1 minutes", " 1 minute");
        //			default:
        //				return "";
        //		}
        //	}
        //}
        //public int BallCount
        //{
        //	get
        //	{
        //		if (CurrentGame != null)
        //			return CurrentGame.BallCount;
        //		return 0;
        //	}
        //}
        //public int BallCountOnOrder
        //{
        //	get
        //	{
        //		if (CurrentGame != null && CurrentGame.BallCountOnOrder.HasValue)
        //			return CurrentGame.BallCountOnOrder.Value;
        //		return 0;
        //	}
        //}
        //public int ExtraBallCount
        //{
        //	get
        //	{
        //		if (CurrentGame != null && CurrentGame.ExtraBallCount.HasValue)
        //			return CurrentGame.ExtraBallCount.Value;
        //		return 0;
        //	}
        //}
        //public string AllowedBallCountsOnOrderString
        //{
        //	get
        //	{
        //		if (CurrentGame == null)
        //			return null;
        //		return CurrentGame.AllowedBallCountsOnOrderStringFiltered;
        //	}
        //}
        //public byte[] AllowedBallCountsOnOrder
        //{
        //	get
        //	{
        //		if (CurrentGame != null)
        //			return CurrentGame.AllowedBallCountsOnOrder;
        //		return null;
        //	}
        //}
        //public bool UsesAllowedBallCountsOnOrder
        //{
        //	get
        //	{
        //		if (CurrentGame == null)
        //			return false;
        //		return !CurrentGame.BallCountOnOrder.HasValue && CurrentGame.AllowedBallCountsOnOrder != null && CurrentGame.AllowedBallCountsOnOrder.Length > 0;
        //	}
        //}
        //public decimal? MinimumAmountPerBet
        //{
        //	get
        //	{
        //		if (CurrentGame == null)
        //			return null;
        //		return CurrentGame.MinimumAmountPerBet;
        //	}
        //}
        //public decimal? MaximumAmountPerBet
        //{
        //	get
        //	{
        //		if (CurrentGame == null)
        //			return null;
        //		return CurrentGame.MaximumAmountPerBet;
        //	}
        //}
        //public int MinimumNumberPerBall
        //{
        //	get
        //	{
        //		if (CurrentGame != null)
        //			return CurrentGame.MinimumNumberPerBall;
        //		return 0;
        //	}
        //}
        //public int MaximumNumberPerBall
        //{
        //	get
        //	{
        //		if (CurrentGame != null)
        //			return CurrentGame.MaximumNumberPerBall;
        //		return 0;
        //	}
        //}
        //public int ExtraBallMinimumNumberPerBall
        //{
        //	get
        //	{
        //		if (CurrentGame != null && CurrentGame.ExtraBallMinimumNumberPerBall.HasValue)
        //			return CurrentGame.ExtraBallMinimumNumberPerBall.Value;
        //		return 0;
        //	}
        //}
        //public int ExtraBallMaximumNumberPerBall
        //{
        //	get
        //	{
        //		if (CurrentGame != null && CurrentGame.ExtraBallMaximumNumberPerBall.HasValue)
        //			return CurrentGame.ExtraBallMaximumNumberPerBall.Value;
        //		return 0;
        //	}
        //}
        //public Guid? CurrentToken { get; set; }
        //public string ExtraData { get; set; }
        //public OrderSources OrderSource = OrderSources.Online; // Default to Online;
        //public Guid? TrackingID = null;
        ////Drawings Variables
        //public List<MCS.Lottery.Contracts.Orders.LotteryDrawing> Drawings { get; set; }
        //public MCS.Lottery.Contracts.Orders.LotteryDrawing CurrentDrawing { get; set; }
        ////Private Variables
        //private IWalletProvider walletProvider = null;
        //private int GameTypeID { get; set; }
        //private List<MCS.Lottery.Contracts.Orders.ValidateOrderBetResult> invalidBets = new List<MCS.Lottery.Contracts.Orders.ValidateOrderBetResult>();
        //private long? custSessionID = null;
        //private static object houseImageLocker = new object();
        //private static Dictionary<int, Tuple<long?, Games_Lottery_HouseImages_Result[]>> houseImageDictionary = null;
        //private Games_Lottery_HouseImages_Result[] houseImages = null;
        //private string _gameName = null;
        //private RecordingAuditLog<ExtraLogData> log = null;

        ////Constructors
        //public WebOrderTakerModel(FranchiseInfoResult franchise, string token, TokenType tokenType, string ip, string hostName, int gameTypeID, RecordingAuditLog<ExtraLogData> existingContext)
        //	: base(franchise, token, tokenType)//, lineItemLimit)
        //{
        //	log = Log.GetAuditor().CreateLogContext("V", "Order Placement (Web)", existingContext);
        //	IPAddress = ip;
        //	HostName = hostName;
        //	GameTypeID = gameTypeID;
        //	AddLog(string.Format("Constructed with parameters: FID = {0}, Token = {1}, TokenType = {2}, IPAddress = {3}, HostName = {4}, GameTypeID = {5}", FranchiseInfo.ID, CustomerID, TokenType, IPAddress, HostName, GameTypeID));
        //	//AddLog(string.Format("Constructed with parameters: FID = {0}, Token = {1}, TokenType = {2}, LineItemLimit = {3}, IPAddress = {4}, HostName = {5}, GameTypeID = {6}", FranchiseInfo.ID, CustomerID, TokenType, LineItemLimit, IPAddress, HostName, GameTypeID));
        //	log.AddDebugStep($"Initialized with parameters: {log.ToJSON(new { franchise, token, tokenType, ip, hostName, gameTypeID })}");
        //	Initialize();
        //}
        //public WebOrderTakerModel(FranchiseInfoResult franchise, string token, TokenType tokenType, string ip, string hostName, int gameTypeID, string extraData, RecordingAuditLog<ExtraLogData> existingContext)
        //	: base(franchise, token, tokenType)//, lineItemLimit)
        //{
        //	log = Log.GetAuditor().CreateLogContext("V", "Order Placement (Web)", existingContext);
        //	IPAddress = ip;
        //	HostName = hostName;
        //	GameTypeID = gameTypeID;
        //	ExtraData = extraData;
        //	//AddLog(string.Format("Constructed with parameters: FID = {0}, Token = {1}, TokenType = {2}, IPAddress = {3}, HostName = {4}, GameTypeID = {5}, ExtraData = {6}", FranchiseInfo.ID, CustomerID, TokenType, IPAddress, HostName, GameTypeID, ExtraData));
        //	log.AddDebugStep($"Initialized with parameters: {log.ToJSON(new { franchise, token, tokenType, ip, hostName, gameTypeID, extraData })}");
        //	Initialize();
        //}
        ////Override Functions
        //protected override void Initialize()
        //{
        //	using (var ctx = Log.GetAuditor().CreateLogContext("V", "Initialization", log))
        //	{
        //		try
        //		{
        //			bets = new List<LotteryOrderBet>();
        //			using (var db = DataFactory.LotteryDB())
        //			{
        //				// Enabled? (Killswitch support)			
        //				if (!IsGameEnabled(GameTypeID))
        //					throw new InvalidOperationException("Gaming is not available at this time. Please try again later.");

        //				// Set default game name.
        //				switch (GameTypeID)
        //				{
        //					case 2: // Keno
        //						_gameName = db.ConfigurationSetting_GetValue("Keno - Display Name");
        //						if (string.IsNullOrWhiteSpace(_gameName))
        //							_gameName = "Keno";
        //						break;
        //					case 3: // Bigball
        //						_gameName = "Bigball";
        //						break;
        //					case 4: // RaffleLottery
        //						_gameName = "RaffleLottery";
        //						break;
        //					default: // Lottery
        //						_gameName = "Lottery";
        //						break;
        //				}

        //				// Load games/drawings for game type
        //				ctx.AddDebugStep("Loading games list.");
        //				LoadGamesList(db);
        //				ctx.AddDebugStep($"Done loading {Games.Count} games.");
        //				if (Games.Count > 0)
        //					CurrentGame = Games.FirstOrDefault(); // Grab the first game in the list by default.

        //				ctx.AddDebugStep("Loading current drawing.");
        //				LoadCurrentDrawing(db);
        //				ctx.AddDebugStep("Done loading current drawing.");

        //				if (!string.IsNullOrWhiteSpace(this.CustomerID)) // The API will init with a null CustomerID if the player is not logged in yet;
        //				{
        //					// Get the configured wallet provider
        //					ctx.AddDebugStep($"Attempting to grab configured wallet provider.");
        //					walletProvider = WalletProviders.GetWalletByName("D5BFBB5D-1799-4966-8CDA-10A9E0B0F556", FranchiseInfo.ID, this.CustomerID, this.TokenType, "", true, CustomerSessionID);
        //					if (walletProvider == null)
        //						throw new InvalidOperationException(MCS.Lottery.Localization.LocalizedResources.Wallet_ProviderNotFound);

        //					//Update the token to the new one.
        //					CurrentToken = walletProvider.GetToken();
        //					ctx.AddDebugStep($"Wallet provider token is {CurrentToken}. Updating customer info...");

        //					// Update the customer information
        //					UpdateCustomerInfo();
        //					ctx.AddDebugStep($"Called update customer info.");
        //					if (walletProvider.Wallet == null)
        //						throw new WalletException(MCS.Lottery.Localization.LocalizedResources.Wallet_DataNotFoundPossibleTimeout);

        //					LastSeenOn = DateTime.Now;
        //					var cust = db.Customers.Where(c => c.ID == Wallet.InternalID).SingleOrDefault();
        //					if (cust != null)
        //					{
        //						ctx.AddDebugStep($"Updating customer last seen time.");
        //						LastSeenOn = (cust.LastSeenOn ?? DateTime.UtcNow).ToLocalTime();
        //						cust.LastSeenOn = DateTime.UtcNow;
        //						cust.LastSeenIPAddress = IPAddress;
        //						cust.LastSeenHostName = HostName;
        //						db.SaveChanges();
        //						ctx.AddDebugStep($"Done updating customer last seen time.");
        //					}
        //				}
        //			}
        //		}
        //		catch (WalletException wex)
        //		{
        //			//AddLog("Wallet error in Initialize(): " + wex.ToString(), wex);
        //			ctx.AddException(wex, "A wallet exception occurred during initialization.", "V");
        //			throw;
        //		}
        //		catch (Exception ex)
        //		{
        //			//AddLog("Initialize() fails.", ex);
        //			ctx.AddException(ex, "A non-wallet exception occurred during initialization.", "X");
        //			throw;
        //		}
        //	}
        //}
        //public override MCS.Lottery.Contracts.Orders.PlaceOrderResult PlaceOrder()
        //{
        //	using (var ctx = Log.GetAuditor().CreateLogContext("V", "Place Order", log))
        //	{
        //		// Assume the worst.
        //		PlaceOrderResult po = new PlaceOrderResult() { IsError = true, Message = LocalizedResources.UnknownServerErrorOccurred };
        //		ctx.AddDebugStep(string.Format("Customer #{4} {3} started with token {0}, Balance {5}, in franchise #{2} {1}, order total is {6}", this.CustomerID, this.FranchiseInfo.Name, this.FranchiseInfo.ID, this.Wallet.ExternalID, this.Wallet.InternalID, this.Wallet.Balance, OrderTotal));

        //		try
        //		{
        //			string msg = "";
        //			int walletAppID = 1; // 4Leaf Online Lottery
        //			if (!WalletApplicationAvailability.IsWalletApplicationAvailable(walletAppID, out msg))
        //			{
        //				ctx.AddBusinessStep("Wallet application is not available; order can not be placed.");
        //				// Gaming is currently disabled. Need to return the reason to the customer.
        //				po.Message = msg;
        //				return po;
        //			}
        //			if (!IsGameEnabled())
        //			{
        //				ctx.AddBusinessStep($"{GameName} is not available; order can not be placed.");
        //				// Gaming is currently disabled. Need to return the reason to the customer.
        //				po.Message = GameName + " is not available at this time. Please try again later.";
        //				return po;
        //			}
        //			var order = new Contracts.Orders.LotteryOrder()
        //			{
        //				FranchiseID = FranchiseInfo.ID,
        //				Bets = bets.ToArray(),
        //				CustomerID = Wallet.InternalID,
        //				TrackingID = (TrackingID ?? Guid.NewGuid()),
        //				OrderSource = OrderSource,
        //			};
        //			// Validate the order.
        //			using (var pl = new MCS.Lottery.Lotto.Orders.PlaceOrder(order.FranchiseID, null, order.OrderSource, 1, walletAppID, CustomerSessionID, ctx))
        //			{
        //				po.ValidationResult = pl.ValidateOrder(order);
        //				ctx.ExtraData.DataModel = po;

        //				ctx.AddDebugStep($"Validation of order resulted in {po.ValidationResult.Result} with {po.ValidationResult.Issues.Length} issues found.");  //debugInfo += string.Format(", validation of order resulted in {0} with {1} issue(s)", po.ValidationResult.Result, po.ValidationResult.Issues.Length);
        //				if (po.ValidationResult.Result != MCS.Lottery.Contracts.Orders.PlaceOrderStatus.Success)
        //				{
        //					ctx.AddBusinessStep("Order cannot be placed due to order/bet validation issues.");
        //					this.invalidBets = po.ValidationResult.Issues.ToList();
        //					//po.Message = MCS.Lottery.Contracts.Orders.LotteryOrderContractTools.PlaceOrderStatusDescription(po.ValidationResult.Result);
        //					if (po.ValidationResult.Issues.Count() > 0)
        //					{
        //						foreach (var b in po.ValidationResult.Issues)
        //						{
        //							RemoveBet((int)b.ID);
        //						}
        //						List<string> errMessages = po.ValidationResult.Issues.Where(i => !string.IsNullOrWhiteSpace(i.Message)).Select(i => i.Message).Distinct().ToList();
        //						po.Message = string.Join("\r\n", errMessages);
        //					}
        //					ctx.ExtraData.DataModel = po;
        //					return po;
        //				}
        //				// Check that the wallet is valid and has a sufficient balance to pay the order.
        //				walletProvider.UpdateWallet();
        //				ctx.AddDebugStep($"Update balance error state: {walletProvider.IsError}; Error is: {(walletProvider.Message ?? "none")}"); //debugInfo += string.Format(", Update balance error is {0}, message is {1}", walletProvider.IsError, walletProvider.Message);
        //				if (walletProvider.Wallet != null)
        //					ctx.AddDebugStep($"Balance at time of update is {walletProvider.Wallet.Balance}"); //debugInfo += string.Format(", balance at time of update wallet was {0}", walletProvider.Wallet.Balance);
        //				if (walletProvider.IsError == true)
        //					po.Message = walletProvider.Message;
        //				else if (walletProvider.Wallet.Balance < order.OrderTotal)
        //					po.Message = LocalizedResources.OrderTaker_CustomerHasInsufficientFunds;
        //				else
        //				{
        //					// Place the order
        //					po.FinalizeOrderResult = pl.FinalizeOrder(order, po.ValidationResult, Wallet.Balance, null, true, null, !walletProvider.IsOurWallet);
        //					if (po.FinalizeOrderResult.Result == MCS.Lottery.Contracts.Orders.PlaceOrderStatus.Success)
        //					{
        //						ctx.AddBusinessStep("Order placement was successful.");
        //						// The debit must occur after placing the order because the transaction ID on our server is required by the wallet.
        //						long? extTXID = null;
        //						try
        //						{
        //							extTXID = walletProvider.AdjustBalance("LOTTERY_SALE", order.OrderTotal, po.FinalizeOrderResult.TransactionID, null, po.FinalizeOrderResult.OrderID, false, CustomerBalanceTypeEnum.CashBalance, false, false, false, null, (int)order.OrderSource);
        //							if (extTXID.HasValue)
        //								po.FinalizeOrderResult.TransactionID = extTXID.Value;
        //							ctx.AddBusinessStep($"Adjusted wallet balance with a lottery sale; external transaction ID #{extTXID}.");
        //						}
        //						catch (WalletException ex)
        //						{
        //							ctx.AddException(ex, "Debiting the customer account resulted in a wallet exception. The wallet should have been checked before this was called.", "V");
        //							//Log.Error("Place Order", "Debiting the customer account resulted in an exception. The wallet should have been checked before this was called. " + debugInfo, ex);
        //							// Rollback the order and quit
        //							MCS.Lottery.Lotto.Orders.PlaceOrder.CancelOrderDueToWalletError(po.FinalizeOrderResult.OrderID, ex.Message);
        //							po.IsError = true;
        //							po.FinalizeOrderResult = null;
        //							po.Message = ex.Message;
        //							return po;
        //						}
        //						catch (Exception ex)
        //						{
        //							ctx.AddException(ex, "Debiting the customer account resulted in a non-wallet exception.", "X");
        //							// Rollback the order and quit
        //							MCS.Lottery.Lotto.Orders.PlaceOrder.CancelOrderDueToWalletError(po.FinalizeOrderResult.OrderID, ex.Message);
        //							po.IsError = true;
        //							po.FinalizeOrderResult = null;
        //							po.Message = ex.Message;
        //							return po;
        //						}

        //						if (!walletProvider.IsOurWallet)
        //						{
        //							// Not using our wallet, so need to update the transaction that was created; For our wallet this was already handled.							 
        //							ctx.AddDebugStep("Not our wallet. Updating transaction with result data.");
        //							var transactionModel = new Transactions();
        //							transactionModel.UpdateTransactionWithWalletResultData(po.FinalizeOrderResult.TransactionID, extTXID);
        //							ctx.AddDebugStep("Updated transaction with result data.");
        //						}

        //						if (!extTXID.HasValue && !walletProvider.IsOurWallet) // Not using our wallet, so extTXID should have value;
        //						{
        //							// There was a problem of some sort.
        //							// Automatically void the order
        //							MCS.Lottery.Lotto.Orders.PlaceOrder.CancelOrderDueToWalletError(po.FinalizeOrderResult.OrderID, "External transaction ID did not have a value.");
        //							po.IsError = true;
        //							po.Message = LocalizedResources.UnknownServerErrorOccurred;
        //							po.FinalizeOrderResult.Result = MCS.Lottery.Contracts.Orders.PlaceOrderStatus.ServerError;
        //							//AddLog(string.Format("External transaction ID did not have a value; order #{0} was canceled.", po.FinalizeOrderResult.OrderID));
        //							ctx.AddBusinessStep($"Canceling order ${po.FinalizeOrderResult.OrderID} due to the external transaction ID not having a value.");
        //						}
        //						else
        //						{
        //							po.IsError = false;
        //							po.Message = null;
        //							ResetOrder();
        //							ctx.AddBusinessStep($"Successfully placed order #{po.FinalizeOrderResult.OrderID} for {po.FinalizeOrderResult.TotalPrice}, wallet ext. ID {extTXID}, internal ID {po.FinalizeOrderResult.TransactionID}.");
        //							//AddLog(string.Format("Successfully placed order #{0} for {1} - wallet ext. ID {2}, internal ID {3}. " + debugInfo, po.FinalizeOrderResult.OrderID, po.FinalizeOrderResult.TotalPrice, extTXID, po.FinalizeOrderResult.TransactionID));
        //						}
        //					}
        //					else
        //					{
        //						ctx.AddBusinessStep("Order placement was not successful.");
        //					}
        //				}
        //			}
        //		}
        //		catch (Exception ex)
        //		{
        //			ctx.AddException(ex);
        //			//AddLog("PlaceOrder() fails. " + debugInfo, ex);
        //		}
        //		return po;
        //	}
        //}
        //public override string OrderTakerModelType { get { return "Web "; } }
        //public override void AddLog(string details, Exception ex = null, string changeLogType = null)
        //{
        //	if (log == null || string.IsNullOrWhiteSpace(details))
        //		return;
        //	if (ex == null)
        //		log.AddDebugStep(details, changeLogType);
        //	else
        //		log.AddException(ex, details, (changeLogType ?? "X"));
        //}
        //public override void ResetOrder()
        //{
        //	log.AddDebugStep("ResetOrder() called.");
        //	base.ResetOrder();
        //	this.invalidBets.Clear();
        //	log.AddDebugStep("ResetOrder() completed.");
        //}
        ////Public Functions
        //public void UpdateCustomerInfo()
        //{
        //	using (var ctx = Log.GetAuditor().CreateLogContext("V", "Updating customer info", log))
        //	{
        //		try
        //		{
        //			walletProvider.UpdateWallet();
        //			this.Wallet = walletProvider.Wallet;
        //			if (walletProvider.IsError == true)
        //			{
        //				throw new InvalidOperationException(walletProvider.Message);
        //			}
        //		}
        //		catch (WalletException wex)
        //		{
        //			AddLog("Wallet error in UpdateWalletToken(): " + wex.ToString(), wex);
        //			throw;
        //		}
        //		catch (Exception ex)
        //		{
        //			AddLog("UpdateCustomerInfo() fails.", ex);
        //			throw;
        //		}
        //	}
        //}
        //public bool IsGameEnabled()
        //{
        //	if (GameTypeID <= 0)
        //		return false;
        //	return IsGameEnabled(GameTypeID);
        //}
        //public bool SwitchGame(string lotteryGameTypeID)
        //{
        //	if (Games == null || Games.Count <= 0)
        //		return false;
        //	CurrentGame = null;
        //	if (GameTypeID == 1) // Lottery so no game changes needed..
        //		return false;
        //	try
        //	{
        //		CurrentGame = Games.Where(g => g.LotteryGameTypeID == lotteryGameTypeID).SingleOrDefault();
        //		return LoadCurrentDrawing();
        //	}
        //	catch { return false; }
        //}
        //public bool SwitchDrawing(long drawingID)
        //{
        //	try
        //	{
        //		if (Drawings == null || Drawings.Count <= 0)
        //			return false;
        //		var drawing = Drawings.Where(d => d.Drawing_ID == drawingID).SingleOrDefault();
        //		if (drawing == null)
        //			return false;
        //		CurrentDrawing = drawing;
        //		return true;
        //	}
        //	catch { }
        //	return false;
        //}
        //public void ReinitializeWithToken(string token)
        //{
        //	try
        //	{
        //		UpdateWalletToken(token);
        //		LoadGamesList();
        //	}
        //	catch (WalletException wex)
        //	{
        //		AddLog("Wallet error in ReinitializeWithToken(): " + wex.ToString(), wex);
        //		throw;
        //	}
        //	catch (Exception ex)
        //	{
        //		AddLog("ReinitializeWithToken() fails.", ex);
        //		throw;
        //	}
        //}
        //public IWalletProvider GetWalletProvider()
        //{
        //	return walletProvider;
        //}
        //public MCS.Lottery.Contracts.Orders.PlaceOrderStatus? CheckBetStatus(MCS.Lottery.Contracts.Orders.LotteryOrderBet bet)
        //{
        //	// TODO: ERROR: There are logs being added for "Sequence contains more than one matching element" for the line below!
        //	// Changed to FirstOrDefault for now, but this should be looked into.
        //	var x = invalidBets.FirstOrDefault(b => b.ID == bet.ID);
        //	if (x != null)
        //	{
        //		return x.Result == MCS.Lottery.Contracts.Orders.PlaceOrderStatus.Success ? (MCS.Lottery.Contracts.Orders.PlaceOrderStatus?)null : x.Result;
        //	}
        //	return null;
        //}
        ////Private Functions
        //private bool IsGameEnabled(int gameTypeID)
        //{
        //	using (var db = DataFactory.LotteryDB())
        //	{
        //		var result = db.GameTypes_IsGameAvailable(gameTypeID, FranchiseInfo.ID, null).Single();
        //		if ((result.IsActive ?? false) == false)
        //			return false;
        //		if ((result.IsDisplayed ?? false) == false)
        //			return false;
        //		return true;
        //	}
        //}
        //private void LoadGamesList()
        //{
        //	using (var db = DataFactory.LotteryDB())
        //	{
        //		LoadGamesList(db);
        //	}
        //}
        //private void LoadGamesList(MCSLotteryEntities db)
        //{
        //	Games = new List<LotteryGame>();
        //	switch (GameTypeID)
        //	{
        //		case 1: // Lottery
        //			LoadLotteryGameList(db);
        //			break;
        //		default:
        //			LoadOtherGameList(db, GameTypeID);
        //			break;
        //	}
        //}
        //private void LoadLotteryGameList(MCSLotteryEntities db)
        //{
        //	var helper = new LottoHelpers();
        //	var list = helper.GetHouseList(db, FranchiseInfo.ID, DateTime.Now, null, System.Globalization.CultureInfo.CurrentCulture.Name)
        //	.GroupBy(r => r.HouseAbbreviation)
        //	.Select(r => new MCS.Lottery.Contracts.Orders.LotteryGame()
        //	{
        //		LotteryGameTypeID = r.ToArray()[0].HouseAbbreviation,
        //		LotteryGameTypeName = r.ToArray()[0].HouseName,
        //		GameTypeID = 1, // Lottery
        //		ImageID = r.ToArray()[0].ImageID,
        //		AdvancedPlayLimit = r.ToArray()[0].AdvancedPlayLimit,
        //		OrderLineItemLimit = r.ToArray()[0].OrderLineItemLimit,
        //		Drawings = r.Select(g => new MCS.Lottery.Contracts.Orders.LotteryDrawing()
        //		{
        //			AllowBoxedBets = g.AllowBoxedBets,
        //			AllowStraightBets = g.AllowStraightBets,
        //			B1 = g.B1,
        //			B2 = g.B2,
        //			B3 = g.B3,
        //			B4 = g.B4,
        //			B5 = g.B5,
        //			B6 = g.B6,
        //			B7 = g.B7,
        //			B8 = g.B8,
        //			B9 = g.B9,
        //			B10 = g.B10,
        //			B11 = g.B11,
        //			B12 = g.B12,
        //			B13 = g.B13,
        //			B14 = g.B14,
        //			B15 = g.B15,
        //			B16 = g.B16,
        //			B17 = g.B17,
        //			B18 = g.B18,
        //			B19 = g.B19,
        //			B20 = g.B20,
        //			BallCount = g.BallCount,
        //			BallCountOnOrder = g.BallCountOnOrder,
        //			CloseDT = g.CloseDT,
        //			CustomLookupKey = g.CustomLookupKey,
        //			Drawing_ID = g.Drawing_ID,
        //			DrawingDT = g.DrawingDT,
        //			FranchiseID = g.FranchiseID,
        //			Games_Lottery_Drawings_ID = g.Games_Lottery_Drawings_ID,
        //			Games_Lottery_Game_ID = g.Games_Lottery_Game_ID,
        //			LotteryGameTypeID = g.HouseAbbreviation,
        //			LotteryGameTypeName = g.HouseName,
        //			ImageID = g.ImageID,
        //			IsActive = g.IsActive ?? false,
        //			IsDisplayed = g.IsDisplayed ?? false,
        //			IsPosted = g.IsPosted,
        //			LotteryType = g.LotteryType,
        //			MaxBetLimit = g.MaxBetLimit,
        //			MaximumAmountPerBet = g.MaximumAmountPerBet,
        //			MaximumNumberPerBall = g.MaximumNumberPerBall,
        //			MinimumAmountPerBet = g.MinimumAmountPerBet,
        //			MinimumNumberPerBall = g.MinimumNumberPerBall,
        //			PayoutFactor = g.PayoutFactor,
        //			PostedAtDT = g.PostedAtDT,
        //			GameTypeID = 1, // Lottery
        //			AdvancedPlayLimit = g.AdvancedPlayLimit,
        //			OrderLineItemLimit = g.OrderLineItemLimit,
        //		}).ToArray(),
        //	}).ToList();
        //	Games.AddRange(list);
        //	// House images
        //	GetHouseImagesForFranchise(db, FranchiseInfo.ID);
        //}
        //private void LoadOtherGameList(MCSLotteryEntities db, int gameTypeID)
        //{
        //	var list = db.Games_GamesByGameType_List(FranchiseInfo.ID, gameTypeID, true, true)
        //	.Select(t => new MCS.Lottery.Contracts.Orders.LotteryGame()
        //	{
        //		LotteryGameTypeID = t.LotteryGameTypeID,
        //		LotteryGameTypeName = t.LotteryGameTypeName,
        //		LotteryType = t.LotteryType,
        //		AllowBoxedBets = t.AllowBoxedBets,
        //		AllowStraightBets = t.AllowStraightBets,
        //		ImageID = t.ImageID,
        //		BallCount = t.BallCount,
        //		ExtraBallCount = t.ExtraBallCount,
        //		ExtraBallCountOnOrder = t.ExtraBallCountOnOrder,
        //		BallCountOnOrder = t.BallCountOnOrder,
        //		MinimumBallCountOnOrder = t.MinimumBallCountOnOrder,
        //		MinimumNumberPerBall = t.MinimumNumberPerBall,
        //		MaximumNumberPerBall = t.MaximumNumberPerBall,
        //		ExtraBallMinimumNumberPerBall = t.ExtraBallMinimumNumberPerBall,
        //		ExtraBallMaximumNumberPerBall = t.ExtraBallMaximumNumberPerBall,
        //		AllowedBallCountsOnOrderString = t.AllowedBallCountsOnOrder,
        //		MinimumAmountPerBet = t.MinimumAmountPerBet,
        //		MaximumAmountPerBet = t.MaximumAmountPerBet,
        //		FranchiseID = t.FranchiseID,
        //		IsActive = t.IsActive,
        //		IsDisplayed = t.IsDisplayed,
        //		MaxBetLimit = t.MaxBetLimit,
        //		AdvancedPlayLimit = t.AdvancedPlayLimit,
        //		OrderLineItemLimit = t.OrderLineItemLimit,
        //		GameTypeID = t.GameTypeID,
        //		Games_Lottery_GameTypeGroup_ID = t.Games_Lottery_GameTypeGroup_ID,
        //		Games_Lottery_GameTypeGroup_Name = t.Games_Lottery_GameTypeGroup_Name,
        //		PermutationCount = t.PermutationCount,
        //		ExtraBallName = t.ExtraBallName,
        //		FeatureDisplayName = t.FeatureDisplayName,
        //		FeatureTicketName = t.FeatureTicketName,
        //		FeatureDataType = t.FeatureDataType,
        //		ExtraPlayAddedAmount = t.ExtraPlayAddedAmount,
        //		IsDependentOnGame = t.IsDependentOnGame,
        //		Dependent_LotteryGameTypeID = t.Dependent_LotteryGameTypeID,
        //		RequiresUniqueBalls = t.RequiresUniqueBalls,
        //	}).ToList();
        //	Games.AddRange(list);
        //}
        //private void GetHouseImagesForFranchise(MCSLotteryEntities db, int franchiseID)
        //{
        //	lock (houseImageLocker)
        //	{
        //		if (houseImageDictionary == null)
        //			houseImageDictionary = new Dictionary<int, Tuple<long?, Games_Lottery_HouseImages_Result[]>>();
        //		long? checksum = null;
        //		Games_Lottery_HouseImages_Result[] result = null;
        //		if (houseImageDictionary.ContainsKey(franchiseID))
        //		{
        //			var rt = houseImageDictionary[franchiseID];
        //			if (rt != null)
        //			{
        //				checksum = rt.Item1;
        //				result = rt.Item2;
        //			}
        //		}
        //		// Check checksum
        //		long? cres = db.Games_Lottery_HouseImages_Checksum(franchiseID).SingleOrDefault() ?? -1;
        //		if (checksum != cres)
        //			result = null; // clear the result as it is now stale
        //		if (result == null)
        //		{
        //			var hires = db.Games_Lottery_HouseImages(franchiseID).ToArray();
        //			var tuple = new Tuple<long?, Games_Lottery_HouseImages_Result[]>(cres, hires);
        //			houseImageDictionary[franchiseID] = tuple;
        //		}
        //		houseImages = houseImageDictionary[franchiseID].Item2;
        //	}
        //}
        //private string GetGameName()
        //{
        //	string ret = _gameName ?? "";
        //	switch (GameTypeID)
        //	{
        //		case 3: // Bigball
        //			if (CurrentGame == null)
        //				return ret;
        //			return CurrentGame.LotteryGameTypeName;
        //		case 4: // RaffleLottery
        //			if (CurrentGame == null)
        //				return ret;
        //			ret = CurrentGame.LotteryGameTypeName;
        //			if (CurrentDrawing != null)
        //				ret += " : " + CurrentDrawing.CustomLookupKey;
        //			return ret;
        //		default:
        //			return ret;
        //	}
        //}
        //private bool LoadCurrentDrawing()
        //{
        //	using (var db = DataFactory.LotteryDB())
        //	{
        //		return LoadCurrentDrawing(db);
        //	}
        //}
        //private bool LoadCurrentDrawing(MCSLotteryEntities db)
        //{
        //	Drawings = new List<LotteryDrawing>();
        //	CurrentDrawing = null;
        //	if (CurrentGame == null)
        //		return false;
        //	int? record_count = (GameTypeID == 4 ? (int?)null : 1);
        //	Drawings = db.Games_DrawingsByGameType_List(FranchiseInfo.ID, CurrentGame.LotteryGameTypeID, record_count)
        //	.Select(t => new MCS.Lottery.Contracts.Orders.LotteryDrawing()
        //	{
        //		Drawing_ID = t.Drawing_ID,
        //		Games_Lottery_Drawings_ID = t.Games_Lottery_Drawings_ID,
        //		Games_Lottery_Game_ID = t.Games_Lottery_Game_ID,
        //		FranchiseID = t.FranchiseID,
        //		LotteryGameTypeID = t.LotteryGameTypeID,
        //		LotteryGameTypeName = t.LotteryGameTypeName,
        //		GameTypeID = t.GameTypeID,
        //		LotteryType = t.LotteryType,
        //		ImageID = t.ImageID,
        //		IsActive = t.IsActive ?? false,
        //		IsDisplayed = t.IsDisplayed ?? false,
        //		MaxBetLimit = t.MaxBetLimit,
        //		MinimumAmountPerBet = t.MinimumAmountPerBet,
        //		MaximumAmountPerBet = t.MaximumAmountPerBet,
        //		MinimumNumberPerBall = t.MinimumNumberPerBall,
        //		MaximumNumberPerBall = t.MaximumNumberPerBall,
        //		BallCount = t.BallCount,
        //		BallCountOnOrder = t.BallCountOnOrder,
        //		ExtraBallCount = t.ExtraBallCount,
        //		DrawingOnSaturday = t.DrawingOnSaturday,
        //		DrawingOnSunday = t.DrawingOnSunday,
        //		DrawingOnMonday = t.DrawingOnMonday,
        //		DrawingOnTuesday = t.DrawingOnTuesday,
        //		DrawingOnWednesday = t.DrawingOnWednesday,
        //		DrawingOnThursday = t.DrawingOnThursday,
        //		DrawingOnFriday = t.DrawingOnFriday,
        //		ExtraBallMinimumNumberPerBall = t.ExtraBallMinimumNumberPerBall,
        //		ExtraBallMaximumNumberPerBall = t.ExtraBallMaximumNumberPerBall,
        //		AllowedBallCountsOnOrderString = t.AllowedBallCountsOnOrder,
        //		AllowStraightBets = t.AllowStraightBets,
        //		AllowBoxedBets = t.AllowBoxedBets,
        //		CustomLookupKey = t.CustomLookupKey,
        //		DrawingDT = t.DrawingDT,
        //		CloseDT = t.CloseDT,
        //		ConvertedCloseDT = t.ConvertedCloseDT,
        //		IsPosted = t.IsPosted,
        //		PostedAtDT = t.PostedAtDT,
        //		B1 = t.B1,
        //		B2 = t.B2,
        //		B3 = t.B3,
        //		B4 = t.B4,
        //		B5 = t.B5,
        //		B6 = t.B6,
        //		B7 = t.B7,
        //		B8 = t.B8,
        //		B9 = t.B9,
        //		B10 = t.B10,
        //		B11 = t.B11,
        //		B12 = t.B12,
        //		B13 = t.B13,
        //		B14 = t.B14,
        //		B15 = t.B15,
        //		B16 = t.B16,
        //		B17 = t.B17,
        //		B18 = t.B18,
        //		B19 = t.B19,
        //		B20 = t.B20,
        //		B21 = t.B21,
        //		B22 = t.B22,
        //		B23 = t.B23,
        //		B24 = t.B24,
        //		B25 = t.B25,
        //		B26 = t.B26,
        //		B27 = t.B27,
        //		B28 = t.B28,
        //		B29 = t.B29,
        //		B30 = t.B30,
        //		TicketPrice = t.MaximumAmountPerBet ?? t.MinimumAmountPerBet,
        //		AdvancedPlayLimit = t.AdvancedPlayLimit,
        //		OrderLineItemLimit = t.OrderLineItemLimit,
        //		PayoutFactor = t.PayoutFactor,
        //		JackpotInfo = ProgressiveJackpot.GetProgressiveJackpotInfo(new PJLookupInfo[] { new PJLookupInfo(t.JackpotGroupID, t.JackpotID, 0, t.LotteryGameTypeID, t.Drawing_ID) }),
        //	}).ToList();
        //	if (Drawings != null && Drawings.Count > 0)
        //		CurrentDrawing = Drawings[0];
        //	return CurrentDrawing != null;
        //}
        //private void UpdateWalletToken(string token)
        //{
        //	log.AddDebugStep($"Attempting to update wallet token '{token}'.");
        //	try
        //	{
        //		this.CustomerID = token;
        //		walletProvider = WalletProviders.GetWalletByName("D5BFBB5D-1799-4966-8CDA-10A9E0B0F556", FranchiseInfo.ID, this.CustomerID, TokenType, "", true, CustomerSessionID);
        //		UpdateCustomerInfo();
        //	}
        //	catch (WalletException wex)
        //	{
        //		log.AddException(wex, null, "V"); //AddLog("Wallet error in UpdateWalletToken(): " + wex.ToString(), wex);
        //		throw;
        //	}
        //	catch (Exception ex)
        //	{
        //		log.AddException(ex); //AddLog("UpdateWalletToken() fails.", ex);
        //		throw;
        //	}
        //}

        #region IDisposable Support
        private bool isDisposed = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!isDisposed)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                    //if (log != null)
                    //{
                    //    log.AddDebugStep("Disposing of WebOrderTakerModel.");
                    //    log.Dispose();
                    //    log = null;
                    //}
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                isDisposed = true;
            }
        }

        //// TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        //// ~WebOrderTakerModel() {
        ////   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        ////   Dispose(false);
        //// }

        //// This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
