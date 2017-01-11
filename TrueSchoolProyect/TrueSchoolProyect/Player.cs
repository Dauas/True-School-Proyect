using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//When sprites are in place we can animate one using a Switch within a for loop
//for (i=0; i<30; i++){
//case (i>=00 && i<10) sprite.texture=Position1.jpg
//case (i>=10 && i<20) sprite.texture=Position2.jpg
//case (i>=20 && i<30) sprite.texture=Position3.jpg
//Rinse and Repeat

namespace TrueSchoolProyect
{
    class Player
    {
        private string username = "";
        private int hp = 100;
        private int maxhp = 100;
        //private int tp = 100;
        //private int maxtp = 100;
        //private int xp = 0;
        //private int requiredxp = 100;
        //private int lv = 1;
        private int score = 1000;

        public void SetUsername(string name)
        {
            username = name;
        }
        public string GetUsername()
        {
            return username;
        }
        public void ReduceHP(int damage)
        {
            if (hp - damage <= 0)
            {
                hp = 0;
            }
            else
            {
            hp = hp - damage;
            }
        }
        public void RestoreHP(int restore)
        {
            if (hp + restore > maxhp)
            {
                hp = maxhp;
            }
            else
            {
                hp = hp + restore;
            }
        }
        public void SetHP(int value)
        {
            hp = value;
        }
        public int GetHP()
        {
            return hp;
        }
        public int GetMaxHP()
        {
            return maxhp;
        }
        //public void ReduceTP(int cost)
        //    {
        //        if (tp - cost < 0)
        //        {
        //        }
        //        else
        //        {
        //            tp = tp - cost;
        //        }
        //    }
        //public Boolean CanCast(int cost)
        //{
        //    if (tp - cost < 0)
        //    {
        //        return false;
        //    }
        //    else{
        //    return false;
        //}
        //}
        //public void RestoreTP(int restore)
        //{
        //    if (tp + restore > maxtp)
        //    {
        //        tp = maxtp;
        //    }
        //    else
        //    {
        //        tp = tp + restore;
        //    }
        //}
        //public void GainXP(int reward)
        //{
        //    xp = xp + reward;
        //    if (xp >= requiredxp)
        //    {
        //        xp = xp - requiredxp;
        //        requiredxp = requiredxp + 50;
        //        LevelUP();
        //    }
        //}
        //public int RemainingXP()
        //{
        //    return (requiredxp - xp);
        //}
        //public void LevelUP()
        //{
        //    lv++;
        //}
        public void ScoreUP(int points)
        {
            score = score + points;
        }
        public int GetScore()
        {
            return score;
        }
        public void SetScore(int newscore)
        {
            score = newscore;
        }
    }
}
