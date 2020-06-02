# Sytool
Sytool is a lightweight tool for flow-based writing. The way it works is very simple- you specify a word count, and then you get a text box. Into the text box you start writing. Most importantly, ***you can not save until you have written the specified word count***. As harsh as this sounds, this is a well-known technique to help get you in the flow of writing no matter what, and stop getting hung up on making things perfect or dwelling a lot on what's already been written. 

# Frequently Asked Questions (F.A.Q.s)
## Q: There are is already {insert web app name} with this functionality, why make something like this?
A: Couple reasons. First of all, the web apps I tried all want to charge you a subscription. While I'm all for paying for software, I have trouble getting my head around buying a subscription for software that is literally so simple, you could throw it together in a couple dozen lines of a high-level language of your choice. 

Second, I'm a bit suspicious of web apps. What if they don't respect your privacy (e.g., they send everything you write to the author's inbox?) Or, what if they shut down and then you're out of luck? For a local program at least you can keep the program. And thirdly, [just because](https://www.robinsloan.com/notes/home-cooked-app/).

## Q: Why is it called Sytool?
A: The original version of this was called "ystool", but when I re-visited it it occurred to me the name has ambiguous ways to pronounce it. So I switched around the first two letters. Now that leads to a question, "why was it originally called ystool". Since the original version was from around 5 years ago I have to say I have no idea.

# Build
The source code of this program is organized as a Visual Studio solution. It is built with Visual Studio 2019. It is written in C# using Windows Forms. It is built for an x86-64 Windows-based environment. It has been tested on Windows 7 and 10. Since Windows Forms is its only interesting dependency it may run on older OSs back to Windows 98 at the earliest but I haven't checked.
