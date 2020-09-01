using Lab06Zoo;
using System;
using Xunit;

namespace Lab06Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Do_dinosaurs_have_teeth()
        {
            Dinosaur Trex = new Dinosaur();

            Assert.True(Trex.Teeth);

        }

        [Fact]

        public void Are_dinosaurs_able_to_walk_on_land()
        {
            Dinosaur Plateosaurus = new Dinosaur();

            Assert.False(Plateosaurus.Land);

        }

        [Fact]
        public void Do_birds_have_feathers()
        {
            Birds Oriole = new Birds();

            Assert.True(Oriole.feathers);

        }

        [Fact]

        public void Do_Mammals_have_fur()
        {
            Mammals pitbull = new Mammals();

            Assert.True(pitbull.fur);

        }

        [Fact]

        public void Can_a_mammal_swim()
        {
            Mammals Hippo = new Mammals();

            Assert.False(Hippo.Swimmer);

        }
    }

}

        
        

        
    

