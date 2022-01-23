using System;

namespace CustomEventSystem
{
    public static class Events
    {
        //Put your events here.
        //Examples:

        //Integer event
        public static readonly Event<int> IntegerEvent = new Event<int>();

        //String and Array event
        public static readonly Event<string, Array> StringArrayEvent = new Event<string, Array>();
    }
}
