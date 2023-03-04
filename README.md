# Pierre's Vendor Tracker

#### By **Carl Sustrich**

## Technologies Used

* C#
* .NET
* MSTest

## Description

A C# based MVC webapp serving as an order tracking interface for a hypothetical bakery.


### Setup Instructions

1. Ensure your computer has the appropriate .NET SDK found [here](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) installed.  
2. Clone this repo.
3. Open your terminal (e.g., Terminal or GitBash) and navigate to this project's production directory called "PierresBakery".
4. In the command line, run the command "dotnet run" to compile and execute the console application. Your default browser should automatically open a tab at the address 'https://localhost:5001/', but you may do so manually as well.
5. If your connection is refused, you may fix this by either clicking the 'advanced' button that accompanies the refuesed message, then click 'connect anyway', or you can trust the security certificate by running the terminal command 'dotnet dev-certs https --trust'.
6. Optionally, you can run "dotnet build" to compile this console app without running it.
7. To run the test suite, you can use the termin command 'dotnet test'.

## Known Bugs

None currently

## License

MIT License

Copyright (c) [2023] [Carl Sustrich]

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
