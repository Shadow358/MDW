//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Runtime.Serialization;

namespace RussianRouletteServiceLibrary.Data
{
    using System;
    using System.Collections.Generic;
    
    [DataContract]
    public partial class Game
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int FirstPlayer { get; set; }
        [DataMember]
        public int SecondPlayer { get; set; }
        [DataMember]
        public Nullable<int> Winner { get; set; }
    
        [DataMember]
        public virtual User User { get; set; }

        [Obsolete("Only needed for serialization and materialization", true)]
        public Game()
        {
            
        }

        public Game(int firstPlayer, int secondPlayer)
        {
            //this.Id = id;
            this.FirstPlayer = firstPlayer;
            this.SecondPlayer = secondPlayer;
        }
    }
}
