   using System.Runtime.Serialization;
   using System.Collections.Generic;
   using System;


    [DataContract]
    public partial class BingoGameVM
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Rows { get; set; }
        [DataMember]
        public int Columns { get; set; }
        [DataMember]
        public string FreeSpotList { get; set; }
        [DataMember]
        public int MinNumber { get; set; }
        [DataMember]
        public int MaxNumber { get; set; }
        [DataMember]
        public bool IsHorizontal { get; set; }
        [DataMember]
        public decimal Price { get; set; }
        [DataMember]
        public Nullable<bool> IsActive { get; set; }
        [DataMember]
        public Nullable<bool> IsDisplayed { get; set; }
        [DataMember]
        public string Alias { get; set; }
        [DataMember]
        public Nullable<System.DateTime> CreatedOn { get; set; }
        [DataMember]
        public Nullable<int> CreatedByStaffID { get; set; }
        [DataMember]
        public virtual List<BingoGameConfigurationVM> BingoGameConfigurations { get; set; }

        [DataMember]
        public virtual List<BingoWinPatternVM> BingoWinPatterns { get; set; }

        public bool isValid()
        {
            //TODO : Validate 
            return true;
        }
    }

    [DataContract]
    public partial class BingoGameConfigurationVM
    {
        [DataMember]
        public long ID { get; set; }       
        [DataMember]
        public int RCIndex { get; set; }
        [DataMember]
        public int MinNumber { get; set; }
        [DataMember]
        public int MaxNumber { get; set; }
        [DataMember]
        public string Subtitle { get; set; }
    }


    [DataContract]
    public partial class BingoWinPatternVM
    {
        public BingoWinPatternVM()
        {
            List<BingoWinBallVM> BingoWinBalls = new List<BingoWinBallVM>();
        }

        [DataMember]
        public long ID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public Nullable<int> Rows { get; set; }
        [DataMember]
        public Nullable<int> Columns { get; set; }
        [DataMember]
        public virtual List<BingoWinBallVM> BingoWinBalls { get; set; }
    }


    [DataContract]
    public partial class BingoWinBallVM
    {
        [DataMember]
        public long ID { get; set; }
        [DataMember]
        public long BingoWinsPatternID { get; set; }
        [DataMember]
        public int BallIndex { get; set; }
        
    }

    [DataContract]
    public class BingoDrawingVM
    {
        [DataMember]
        public long ID { get; set; }
        [DataMember]
        public DateTime StartDate { get; set; }
        [DataMember]
        public DateTime? EndDate { get; set; }
        [DataMember]
        public bool? IsAutomatic { get; set; }
        [DataMember]
        public int? IntervalBetweenBallsSec { get; set; }
        [DataMember]
        public int BingoGameID { get; set; }
        [DataMember]
        public int? FranchiseID { get; set; }
        [DataMember]
        public decimal? CardPrice { get; set; }
        [DataMember]
        public DateTime CreatedOn { get; set; }
        [DataMember]
        public DateTime? CloseDT { get; set; }
        [DataMember]
        public virtual ICollection<BingoCardVM> BingoCards { get; set; }
        [DataMember]
        public virtual ICollection<BingoDrawingBallVM> BingoDrawingBalls { get; set; }
        //[DataMember]
        //public virtual ICollection<BingoDrawingPrize> BingoDrawingPrizes { get; set; }
        [DataMember]
        public virtual BingoGameVM BingoGame { get; set; }
        
    }

    [DataContract]
    public partial class BingoDrawingBallVM
    {
        [DataMember]
        public long ID { get; set; }
        [DataMember]
        public long BingoDrawingID { get; set; }
        [DataMember]
        public System.DateTime DrawnDt { get; set; }
        [DataMember]
        public int BallNumber { get; set; }

      
    }
    [DataContract]
    public class BingoCardVM
    {
        [DataMember]
        public long ID { get; set; }
        [DataMember]
        public long BingoDrawingID { get; set; }
        [DataMember]
        public long CustomerID { get; set; }
        [DataMember]
        public bool? IsCustomerCalledBingo { get; set; }
        [DataMember]
        public DateTime? CreatedOn { get; set; }
        [DataMember]
        public virtual ICollection<BingoCardNumberVM> BingoCardNumbers { get; set; }
    }

    [DataContract]
    public class BingoCardNumberVM
    {

        [DataMember]
        public long ID { get; set; }
        [DataMember]
        public long BingoCardID { get; set; }
        [DataMember]
        public int BallIndex { get; set; }
        [DataMember]
        public int Number { get; set; }
        [DataMember]
        public bool? IsCustomerChecked { get; set; }
        [DataMember]
        public DateTime? CheckedOn { get; set; }        
    }