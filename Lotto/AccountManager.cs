////using System;
//////using System.Collections.Generic;
//////using System.Linq;
//////using System.Text;
//////using System.Threading.Tasks;
//////using MCS.Lottery.Contracts.Wallet;
//////using MCS.Lottery.Data;
//////using MCS.Lottery.Logging;
//////using MCS.Lottery.Lotto.PlaceOrder;
//////using MCS.Lottery.Lotto.Syndicates;
//////using MCS.Auditing;

////namespace SpaBingo.Lotto
////{
////    public class AccountManager
////    {
////        /// <summary>
////        /// Grab Franchise Info by Key (ReplicationID on Franchise Table)
////        /// </summary>
////        /// <param name="key"></param>
////        /// <returns></returns>

///// <summary>
///// Grab Franchise Info by Key (ReplicationID on Franchise Table)
///// </summary>
///// <param name="key"></param>
///// <returns></returns>
//public Contracts.FranchiseInfoResult GetFranchiseInfoFromKey(Guid key)
//{
//    using (var db = Data.DataFactory.LotteryDB())
//    {
//        var franchise = db.Franchises.Where(f => f.ReplicationID == key).SingleOrDefault();
//        if (franchise == null)
//            return null;
//        return new Contracts.FranchiseInfoResult()
//        {
//            ID = franchise.ID,
//            FranchiseGUID = franchise.ReplicationID,
//            IsActive = franchise.IsActive,
//            Name = franchise.Name,
//            CurrencyCulture = franchise.CurrencyCulture,
//            CardSwipeRequired = franchise.IsSwipeRequired,
//            OrderValidDays = franchise.OrderValidDays,
//            ATMCardParsingRegex = franchise.ATMCardParsingRegex,
//            AllowFractionalBets = franchise.AllowFractionalBets,
//            Denominations = franchise.Denominations,
//            CurrencyCode = franchise.Wallet_Currency

//        };
//    }
//}

//    }
////}
