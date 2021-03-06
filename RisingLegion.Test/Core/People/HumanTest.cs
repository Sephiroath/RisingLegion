﻿using System.Collections.Generic;
using RisingLegion.Core.People;
using RisingLegion.Core.Stats;
using Xunit;

namespace RisingLegion.Test.Core.People
{
    public class HumanTest
    {
        private readonly Human _human; 
        private readonly Human _human2; 
        
        public HumanTest()
        {
            _human = new Human(20, 9)
            {
                Id = 1,
                Attributeses = new List<IStat>
                {
                    new Intelligence
                    {
                        Amount = 90
                    },
                    new Dexterity
                    {
                        Amount = 20
                    },
                    new Strength
                    {
                        Amount = 20
                    }
                }
                
            };
            _human2 = new Human(20, 10)
            {
                Id = 1,
                Attributeses = new List<IStat>
                {
                    new Strength
                    {
                        Amount = 70
                    }
                }
                
            };
        }
        [Fact]
        public void CanGetStats()
        {
            var intelligence = _human.CurrentIntelligence;
            var strength = _human.CurrentStrength;
            var dexterity = _human.CurrentDexterity;
            Assert.Equal(90, intelligence);
            Assert.Equal(20, dexterity);
            Assert.Equal(20, strength);
        }

        [Fact]
        public void CanGetProperHealth()
        {
            Assert.True(_human.Warrior.BaseHealth < _human2.Warrior.BaseHealth);
        }

        [Fact]
        public void CanGetProperDamage()
        {
            Assert.True(_human.Warrior.BaseDamage < _human2.Warrior.BaseDamage);
        }
        [Fact]
        public void CanGetProperDefense()
        {
            Assert.True(_human.Warrior.BaseDefense < _human2.Warrior.BaseDefense);
        }
    }
}