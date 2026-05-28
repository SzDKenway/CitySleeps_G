namespace Game
{
    public class Player
    {
        public string CharacterName { get; set; }
        public string PlayerName { get; set; }
        public int HP { get; set; }
        /// <summary>
        /// is night active
        /// </summary>
        public bool IsNightActive { get; set; }
        /// <summary>
        /// List for infected ones
        /// </summary>
        public List<Player> VictimList { get; set; } 
        /// <summary>
        /// power explanation
        /// </summary>
        public string PowerString { get; set; }
        /// <summary>
        /// was picked into the starterPack
        /// </summary>
        public bool IsActive { get; set; } 
        /// <summary>
        /// denied power usage during the night phase
        /// </summary>
        public bool DeniedP {  get; set; }
        public bool IsDead { get; set; }
        /// <summary>
        /// Player was called already during the night phase no mather if they alive or dead
        /// </summary>
        public bool IsShowed { get; set; }
        public Player(string player_N)
        {
            CharacterName = "NINCS";
            PlayerName = player_N;
            HP = 100;
            StillAlive(HP);
            VictimList = new List<Player>();
            IsDead = false;
            IsNightActive = true;
            IsActive = false;
            DeniedP = false;
            IsShowed = false;
        }

        //Targeting miatt kell tudni másolni
        public Player(Player otherP)
        {
            CharacterName= otherP.CharacterName;
            PlayerName = otherP.PlayerName;
            HP = otherP.HP;
            StillAlive(HP);
            VictimList = new List<Player>(); // új listát hozz létre!!! (elmétileg nem számit)
            IsDead = false;
            IsActive = otherP.IsActive;
            PowerString = otherP.PowerString;
            IsNightActive = otherP.IsNightActive;
            DeniedP = otherP.DeniedP;
            IsShowed = false;
        }

        public override string ToString()
        {
            return PlayerName;
        }

        /// <summary>
        /// IsnightActive and PowerString switches
        /// </summary>
        public void CharacterSpecifier()
        {
            IsNightSwitch();
            PowerStringSwitch();
        }

        /// <summary>
        /// Switch for PowerString (képesség kiírás)
        /// </summary>
        public void PowerStringSwitch()
        {
            switch (CharacterName)
            {
                case "Csonkito":
                    PowerString = "Elnémít / képességet vesz el / szavazás jogot vesz el";
                    break;

                case "Gyilkos":
                    PowerString = "Éjszaka -50 HP sebzést okoz egy játékosnak.";
                    break;

                case "Keresztapa":
                    PowerString = "Éjszaka -75 HP sebzést okoz egy játékosnak.";
                    break;

                case "Felugyelo":
                    PowerString = "Kiválasztott játékos éjszaka nem használhat képességet. Ha Gyilkos akkor rögtön meghal, ha keresztapát talál akkor sebzi is 50-nel.";
                    break;

                case "Orvos":
                    PowerString = "Éjszaka gyógyít egy játékost (+50 HP).";
                    break;

                case "Kislany":
                    PowerString = "Éjszaka kémkedhet, információt szerez.";
                    break;

                case "Logan":
                    PowerString = "Csak nappal lehet megölni.";
                    break;

                case "Saman":
                    PowerString = "Egyszer gyógyít (+50), egyszer sebez (-50).";
                    break;

                case "Selyemfiu":
                    PowerString = "Minden nap 25 poison sebzést ad célpontjának.";
                    break;

                case "Alien":
                    PowerString = "Megöli azt, aki felterjesztette.";
                    break;

                case "Farajo":
                    PowerString = "visszateszi az HP 100ra ha kevesebb van, és leszed a selyemfiú listájáról";
                    break;

                case "John Wick":
                    PowerString = "ha meghal a kislány akkor ölhet onnantól, néppel van.";
                    break;

                case "Prosti":
                    PowerString = "Le tudja venni a poison hatást.";
                    break;

                case "Cupido":
                    PowerString = "Két játékost összeköt.";
                    break;

                case "Polgarmester":
                    PowerString = "Felfedheti magát mint polgármester.";
                    break;

                case "Orban Viktor":
                    PowerString = "Csak 2/3 többséggel lehet kiszavazni.";
                    break;

                case "Porszivougynok":
                    PowerString = "Minden élő játékosnak el kell adnia.";
                    break;

                case "Novak Katalin":
                    PowerString = "Éjszaka védetté tesz egy játékost nappalra.";
                    break;

                case "Magyar Peter":
                    PowerString = "A kiválasztott játékos azonnal kiesik.";
                    break;

                default:
                    PowerString = "Nincs speciális képesség.";
                    break;
            }
        }

        /// <summary>
        /// Switch for player.IsNightActive (azoknak false akiknek NEM kell felkelni este)
        /// </summary>
        public void IsNightSwitch()
        {
            switch (CharacterName)
            {
                case "John Wick":
                    IsNightActive = false;
                    break;
                case "Kislany":
                    IsNightActive = false;
                    break;
                case "Logan":
                    IsNightActive = false;
                    break;
                case "Polgarmester":
                    IsNightActive = false;
                    break;
                case "Orban Viktor":
                    IsNightActive = false;
                    break;
                case "Magyar Peter":
                    IsNightActive = false;
                    break;
                case "Alien":
                    IsNightActive = false;
                    break;
            }
        }

        public bool StillAlive(int x)
        {
            if (x <= 0)
            {
                return false;
            }
            return true;
        }
    }
}
