# vscode-visualbasic-forms-example
So, as usual, I'm late to the party! This time the party is VS Code and it's pretty ~~fun~~ okay. Instead of just playing around with JavaScript or HTML, I thought why not see if I can write Visual Basic code and send it to the compiler. 

So I had a quick Google search and found [this link](https://github.com/formulahendry/vscode-code-runner/issues/55). The guys at Code Runner already received a request to support VB and C Sharp and by nature of what Code Runner does, all you need to do is add a rule for the file extension! 

I had to track down my `vbc.exe` for my system, as the path in that GitHub issue didn't exist. I let Windows Search do work of tracking it down, just typed in `vbc.exe` and let it run its course. It found five version on my C Drive, each corresponding to a different .NET Framework version. I had options for `1.3.2`, `2.0.1`, `2.1.0`, `2.4.0`, and `2.6.1` so I settled on `2.6.1`.

First, I made a new file `HelloWorld.vb`
and wrote the following script

`Module HelloWorld`
`Sub Main()`
`System.Console.WriteLine("Hello World!")`
`End Sub`
`End Module`

And that worked fine, so I went to the next step: Forms!


I created a new file called `HelloWorld-form.vb` and started writing another "Hello World" script that looked like this:

`Class HelloWorld` 
` Sub Main() `
` MessageBox.Show("Hello World!")`
` End Sub`
`End Class`

Annnnnddddd it failed to compile.

Why? Well VS Code has an Output window that will tell you! It didn't like two things I was doing.

**One: MessageBox**

It had no idea what a MessageBox was. Every other time I've made a Windows Form project in Visual Studio, it's just worked and that's because Visual Studio does almost all of the lifting when it comes to designing forms. When you create a WinForm project, visual studio handles building the initial form using the default properties. This includes the most important reference for the Form! 

`Imports System.Windows.Forms`

So I put that at Line 1 and bam! Still not compiling, but now it didn't yell at me for the MessageBox. This was a less confusing but more silly issue that the compiler told me outright: 

**Two: No accessible 'Main' method with an appropriate signature was found**

I wrote the second script as a Class this time, not a module! Doh! You can have your Sub Main() in a Class, by the way, but you'll need to define it as:

`Public Shared Sub Main()`

But I just changed my class to a module and finally, I was getting a MessageBox!

From that point, it was just a matter of defining a form and some controls, then adding the controls to the form, and then adding a few event handlers. 
