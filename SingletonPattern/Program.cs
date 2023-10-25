/* Could you provide an example of how to implement the Singleton Design Pattern
 in C# for creating a class with a single instance?
and the class is logger , logger can implement different strategy for file and for db
*/
Logger myLogger = Logger.CreateInstance();
myLogger.LogMessage(new FileLog(),"File Message");
myLogger.LogMessage(new ConsoleLog(),"Console Message");