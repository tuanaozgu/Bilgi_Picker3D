using System;

namespace Data.ValueObjects
{
    [Serializable]
    public struct PlayerData
    {
        public MovementData movementData;
        public ScaleData scaleData;

    }
    
    [Serializable]
    public struct MovementData
    {
        public float forwardSpeed;
        public float sidewaysSpeed;
        public float forwardForceCounter;

        public MovementData(float forwardSpeed, float sidewaysSpeed, float forwardForceCounter)
        {
            this.forwardSpeed = forwardSpeed;
            this.sidewaysSpeed = sidewaysSpeed;
            this.forwardForceCounter = forwardForceCounter;
        }
    }
    
    [Serializable]
    public struct ScaleData
    {
        public float scaleCounter;

        public ScaleData(float scaleCounter)
        {
            this.scaleCounter = scaleCounter;
        }
    }
}
