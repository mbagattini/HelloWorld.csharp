# HelloWorld.csharp

![thumbnail](./Thumbnail.jpeg)

Welcome to the converted version of the first **Nanowar Of Steel** GitHub project. This revised repository is aimed to all those programmers out there who indentify themselves as C# developers.

Some important notes:
1. To maintain the song sorce code as close as possible to the original, I mixed common C# conventions with those adopted in the java version: the `foo` property should have been `_foo`, but in my personal opinion it would have make the song unsingable
2. System is redundant, it's there to keep up with the metric
3. Due to the different behavior of the `Lenght` property on the `String` class, I opted for an invokable method instead, using `.Trim()`
4. The thrown exception, although similar to the original one, is instead a `NullReferenceException`

## Usage

Once you run the program, you will see the following output:

```
Hello World Programmer Start
Hello World!
Hello World!
Hello World!
Hello World!
Program Finished!
Unhandled exception. System.NullReferenceException: Object reference not set to an instance of an object.
   at it.Nanowar.OfSteel.HelloWorld.HelloWorldMainLauncherClass.FalseMethod() in C:\Dev\HelloWorld.csharp\Class1.cs:line 49
   at it.Nanowar.OfSteel.HelloWorld.HelloWorldMainLauncherClass.Main(String[] args) in C:\Dev\HelloWorld.csharp\Class1.cs:line 33
```

# License

I don't actually know how it works, don't sue me.

# Contributing

Feel free to fork this repository, submit issues, or open pull requests if you'd like to improve this code. Contributions are always welcome!