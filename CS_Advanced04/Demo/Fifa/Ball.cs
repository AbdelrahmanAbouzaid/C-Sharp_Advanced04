using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Fifa
{
    #region Without Event
    //internal class Ball
    //{
    //    public int Id { get; set; }
    //    private Location location;
    //    public List<Player> Players { get; set; } = new List<Player>();
    //    public List<Refree> Refrees { get; set; } = new List<Refree>();
    //    public Location Location
    //    {
    //        get { return location; }
    //        set
    //        {
    //            if (!Location.Equals(value))
    //            {
    //                foreach (var item in Players)
    //                {
    //                    item.Run(this);
    //                }
    //                foreach (var item in Refrees)
    //                {
    //                    item.Look(this);
    //                }
    //            }
    //            location = value;

    //        }
    //    }

    //    public override string ToString() => $"Location: {Location}";

    //} 
    #endregion
    internal class Ball
    {
        public int Id { get; set; }
        private Location location;
        public Location Location
        {
            get { return location; }
            set
            {
                location = value;
                if (BallLocationChange is not null)
                    BallLocationChange.Invoke(this);

            }
        }

        public event Action<Ball> BallLocationChange;
        public override string ToString() => $"Location: {Location}";

    }

}
