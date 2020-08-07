using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MatrixJam.Team4
{
    public abstract class Player : MonoBehaviour
    {
        private int _score;
        private List<Unit> _myUnits;

        public int Score { get => _score; set => _score = value; }
        public List<Unit> MyUnits { get => _myUnits; set => _myUnits = value; }

        public virtual TurnObject yourTurn(TurnData turnData) { return null; }

        protected TurnObject validateTurnObject(TurnObject validationObject)
        {
            if (validationObject.ChosenPositionIndex == null)
            {
                return null;
            }

            if (validationObject.ChosenUnit == null)
            {
                return null;
            }

            return validationObject;
        }
    }
}