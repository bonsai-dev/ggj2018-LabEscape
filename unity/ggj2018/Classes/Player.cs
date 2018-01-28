using System;
using System.Collections.Generic;
using ggj2018.ENUMs;
using ggj2018.Controller;

namespace ggj2018.Classes
{
    class Player
    {
        private Guid _playerId;
        private double _positionX;
        private double _positionY;
        private bool _isActive;
        private List<EnumVirus> _viruses;

        public Player(double positionX, double positionY)
        {
            _positionX = positionX;
            _positionY = positionY;

            _playerId = Guid.NewGuid();
        }

        public void BecomeInfected(List<EnumVirus> viruses)
        {
            if (viruses.Count == 0)
            {
                _viruses.Add(CtlVirus.GetRandomVirus());
            }
            else
            {

                foreach (var virus in viruses)
                {
                    if (!_viruses.Contains(virus))
                        _viruses.Add(virus);
                }
            }

            Say(CtlTalking.GetRandomPlayerInfectionText());

            _isActive = true;
        }

        public void Say(string Text)
        {
            //say text
        }
    }
}
