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
        public float ForwardSpeed;
        public float SidewaysSpeed;
        public float ForwardForceCounter;

        public MovementData(float forwardSpeed, float sidewaysSpeed, float forwardForceCounter)
        {
            this.ForwardSpeed = forwardSpeed;
            this.SidewaysSpeed = sidewaysSpeed;
            this.ForwardForceCounter = forwardForceCounter;
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
