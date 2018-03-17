# Experimenting with Wasm and .NET with Blazor

This is an experiment where I wanted to use .NET not to render a page but to do
some computation, while I still use HTML and JavaScript.

I got it working, and you can try it
[installing Blazor](http://aka.ms/install-blazor) and running this project.

You can call from C# into JS and from JS into C#.

I also ran some performance tests. Blazor is still slower than JS. Here are
the results:

| Performance   | Chrome | Firefox |
| ------------- | ------:| -------:|
| C# | 1497 | 926|
| JS | 20 | 12|
| C# non optimized | 10.003 | 6.608 |
| JS non optimized | 845 | 1.020 |

Don't call the threads example, it locks the browser.

## Author

* [Giovanni Bassi](http://blog.lambda3.com.br/L3/giovannibassi/), aka Giggio, [Lambda3](http://www.lambda3.com.br), [@giovannibassi](https://twitter.com/giovannibassi)

## Contact

Use Twitter.