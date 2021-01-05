using System;

namespace Task043
{
    // I read that constant interface pattern is a poor use of interfaces
    // I did something close to the task

    class Program
    {
        static void Main(string[] args)
        {
            GameObject gamer = new GameObject();
            gamer.MoveLeft();
            gamer.IsOK();
            gamer.CurrentMoveDirection();
        }
    }

    interface IStatusCodes
    {
        public void IsOK();

        public void IsNOTOK();
    }

    interface IDirection
    {
        public void MoveLeft();

        public void MoveRight();

        public void MoveUp();

        public void MoveDown();
    }

    class GameObject : IStatusCodes, IDirection
    {
        private string direction;
        private string status;
        private string Direction
        {
            get { return direction; }
            set { direction = value; }
        }

        private string Status
        {
            get { return status; }
            set { status = value; }
        }

        public GameObject()
        {

        }

        public void IsOK()
        {
            Status = "OK";
        }

        public void IsNOTOK()
        {
            Status = "NOK";
        }

        public void MoveLeft()
        {
            Direction = "LEFT";
        }

        public void MoveRight()
        {
            Direction = "RIGHT";
        }

        public void MoveUp()
        {
            Direction = "UP";
        }

        public void MoveDown()
        {
            Direction = "DOWN";
        }

        public void CurrentMoveDirection()
        {
            Console.WriteLine("{0}, {1}", Direction, Status);
        }
    }
}
