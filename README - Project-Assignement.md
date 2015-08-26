<article class="markdown-body entry-content" itemprop="mainContentOfPage"><h1><a id="user-content-high-quality-programming-code--team-projects" class="anchor" href="#high-quality-programming-code--team-projects" aria-hidden="true"><span class="octicon octicon-link"></span></a>High-Quality Programming Code – Team Projects</h1>

<h2><a id="user-content-overview" class="anchor" href="#overview" aria-hidden="true"><span class="octicon octicon-link"></span></a>Overview</h2>

<p>You are given a <strong>C# software project</strong> designed to implement some of the following <strong>console-based games</strong>:</p>

<ul>
<li>  Balloon Pops</li>
<li>  Battle Field</li>
<li>  Bulls and Cows</li>
<li>  Game 15</li>
<li>  Hangman</li>
<li>  King Survival</li>
<li>  Labyrinth</li>
<li>  Minesweeper</li>
</ul>

<p>The project consists of one or more <strong>source code files</strong>, description and is provided here: <a href="https://github.com/TelerikAcademy/High-Quality-Code/tree/master/Teamwork">https://github.com/TelerikAcademy/High-Quality-Code/tree/master/Teamwork</a>.</p>

<p>The name of your team is the same as the project you will start from.</p>

<p>You need to refactor the project in order to <strong>improve its quality</strong> following the best practices learned in the course “<a href="http://telerikacademy.com/Courses/Courses/Details/244">High-Quality Programming Code</a>” and to <strong>implement unit tests</strong> that ensure that the code has correct behavior.</p>

<h2><a id="user-content-detailed-assignment-description" class="anchor" href="#detailed-assignment-description" aria-hidden="true"><span class="octicon octicon-link"></span></a>Detailed Assignment Description</h2>

<p>In order to ensure the high quality of the assigned project you need to fulfill the following tasks:</p>

<ol>
<li> <strong>Perform refactoring of the entire project</strong> (its directory structure, project files, source code, classes, interfaces, methods, properties, fields and other class members and program members and its programming logic) in order to <strong>make the code “high quality”</strong> according to the best practices introduced in the course “<a href="http://telerikacademy.com/Courses/Courses/Details/244">High-Quality Programming Code</a>”. The obtained <strong>refactored code</strong> should conform to the following characteristics:

<ul>
<li>  <strong>Easy to read, understand and maintain</strong> – the code should be well structured; should be easy to read and understand, easy to modify and maintain; should follow the concept of self-documenting code; should use good names for classes, methods, variables, and other identifiers; should be consistently formatted following the best formatting practices; should have strong cohesion at all levels (modules, classes, methods, etc.); should have loose coupling between modules, classes, methods, etc.; should follow the best practices of organizing programming logic at all levels (classes, methods, loops, conditional statements and other statements); should follow the best practices for working with variables, data, expressions, constants, control structures, exceptions, comments, etc.</li>
<li>  All <strong>default StyleCop rules should pass</strong> without any warning.</li>
<li>  <strong>Correct behavior</strong> – the project should fulfill correctly the requirements and to behave correctly in all possible use cases. This means that all bugs or other problems in the project (e.g. performance or usability issues) should be fixed and any unfinished or missing functionality should be completed. The code should be very well tested with properly designed unit tests.</li>
</ul></li>
<li> <strong>Implement design patterns</strong> – redesign the project to fulfil 9 of the <a href="http://en.wikipedia.org/wiki/Software_design_pattern">Software Design patterns</a>

<ul>
<li>  <strong>Structural patterns</strong> – implement <strong>at least 3</strong> of the structural design patterns (adapter, aggregate, bridge, composite, decorator, extensibility, façade, etc…)</li>
<li>  <strong>Behavior patterns</strong> – implement <strong>at least 3</strong> of the behavioral design patterns (chain of responsibility, command, interpreter, iterator, mediator, observer, etc…)</li>
<li>  <strong>Creational patterns</strong> – implement <strong>at least 3</strong> of the creational design patterns (abstract factory, builder, factory method, singleton, prototype, etc…)</li>
</ul></li>
<li> <strong>Follow the SOLID and DRY principles</strong> – Single responsibility, Open/close, Liskov substitution, Interface segregation, Dependency inversion, Don't repeat yourself

<ul>
<li>  Redesign the project to fulfil the <a href="http://en.wikipedia.org/wiki/Solid">SOLID</a> and <a href="http://en.wikipedia.org/wiki/Don't_repeat_yourself">DRY</a> principles – each principle should be implemented at least once</li>
</ul></li>
<li> <strong>Design and implement unit tests</strong> covering the entire project functionality. To ensure the project works correctly according to the requirements and behaves correctly in all possible use cases, design and implement unit tests that cover all use cases and the entire program logic. If needed, first redesign the program logic to <strong>make the code testable</strong>. Test the normal expected behavior (correct data) and possible expected failures (incorrect data). Put special attention to the border cases.

<ul>
<li>  The code coverage of the unit tests should be at least 90%.</li>
<li>  Use unit testing framework of your choice (e.g. Visual Studio Team Test, NUnit, MbUnit or other).</li>
<li>  At least 10 of your tests should use <strong>mocking</strong> (Moq, JustMock or other).</li>
</ul></li>
<li> Documentation and comments

<ul>
<li>  <strong>Document the refactorings</strong> you have performed in order to improve the quality of the project. Use English language and follow the sample (see below). The documentation must be in <code>.md</code> (GitHub Markdown) format.</li>
<li>  Document all public members and classes using <strong>XML documentation</strong> within the code and generate <strong>CHM documentation</strong>.</li>
<li>  Add <strong>code comments</strong> where appropriate</li>
</ul></li>
<li> <strong>Add new functionalities</strong> to the game. The more functionalities you add the more points you will get.

<ul>
<li>  Follow all principles and unit test you new game functionalities.</li>
</ul></li>
</ol>

<h2><a id="user-content-deliverables" class="anchor" href="#deliverables" aria-hidden="true"><span class="octicon octicon-link"></span></a>Deliverables</h2>

<ol>
<li> The <strong>original source code</strong> (project files, .cs files) without executables (in folder <code>/before/</code>).</li>
<li> The <strong>refactored source code</strong> (project files, .cs files) without executables (in folder <code>/src/</code>).</li>
<li> The <strong>unit tests</strong> – source code (project files, .cs files) without executables (in folder <code>/tests/</code>).</li>
<li> The <strong>refactoring documentation</strong>. (<code>README.md</code> file)</li>
</ol>

<h2><a id="user-content-team-work-requirements" class="anchor" href="#team-work-requirements" aria-hidden="true"><span class="octicon octicon-link"></span></a>Team Work Requirements</h2>

<ul>
<li>  Obligatory use <strong>Git</strong> as source code repository and <strong>GitHub</strong> (<a href="http://github.com">http://github.com</a>) as project hosting and team collaboration environment. SVN or TFS are <strong>not</strong> allowed for this project.

<ul>
<li>  Take advantage of the GitHub issues for project management</li>
</ul></li>
<li>  <strong>Each team member</strong> should have contributions to the project and <strong>commits in the source control repository in 7 different days</strong>. We acknowledge that this requirement seems a bit unnatural, but we want to track <strong>how the team collaborates over the time</strong> and that the <strong>project is developed incrementally</strong>, not in the “last minute”.</li>
</ul>

<h2><a id="user-content-other-requirements" class="anchor" href="#other-requirements" aria-hidden="true"><span class="octicon octicon-link"></span></a>Other Requirements</h2>

<ul>
<li>  Every team member should send the project in the students system <a href="http://telerikacademy.com">http://telerikacademy.com</a>.

<ul>
<li>  Pack the project deliverables in a <strong>single ZIP archive</strong>.</li>
<li>  Be sure to avoid including large unused files in the archives (e.g. compilation binaries).</li>
<li>  Your archive should be up to 8 MB.</li>
<li>  Each team member should submit the same archive as a homework.</li>
</ul></li>
<li>  Be prepared as a team to <strong>defend your project</strong> in front of the course lecturers. You should be able to explain what refactorings have been performed and why. The documentation will definitely help you. Be prepared to <strong>demonstrate how the unit tests cover the project’s functionality</strong>. Preferably bring your own laptop to reduce the effort to setup your development environment and project workspace.</li>
<li>  Be prepared to <strong>explain the used patterns and SOLID principles</strong>.</li>
<li>  Be prepared to <strong>show the commit logs</strong> from the source control system to demonstrate how the project development efforts are shared between the team members and over the time.</li>
</ul>

<h2><a id="user-content-discussion-forum" class="anchor" href="#discussion-forum" aria-hidden="true"><span class="octicon octicon-link"></span></a>Discussion Forum</h2>

<ul>
<li>  You can freely discuss the course projects and ask questions in the official discussion forum of the course: <a href="https://telerikacademy.com/Forum/Category/19/c#-qpc">https://telerikacademy.com/Forum/Category/19/c#-qpc</a></li>
</ul>

<h2><a id="user-content-sample-refactoring-documentation-for-project-game-15--------------------------------------------------------------------------------------------------------------------------" class="anchor" href="#sample-refactoring-documentation-for-project-game-15--------------------------------------------------------------------------------------------------------------------------" aria-hidden="true"><span class="octicon octicon-link"></span></a>Sample Refactoring Documentation for Project “Game 15”                                                                                                                          </h2>

<ol>
<li> Redesigned the project structure: Team “…”

<ul>
<li>  Renamed the project to <code>Game-15</code>.</li>
<li>  Renamed the main class <code>Program</code> to <code>GameFifteen</code>.</li>
<li>  Extracted each class in a separate file with a good name: <code>GameFifteen.cs</code>, <code>Board.cs</code>, <code>Point.cs</code>.</li>
<li>  …</li>
</ul></li>
<li><p>Reformatted the source code:</p>

<ul>
<li>  Removed all unneeded empty lines, e.g. in the method <code>PlayGame()</code>.</li>
<li>  Inserted empty lines between the methods.</li>
<li>  Split the lines containing several statements into several simple lines, e.g.:</li>
</ul>

<p>Before:</p>

<pre><code>if (input\[i\] != ' ') break;
</code></pre>

<p>After:</p>

<pre><code>if (input\[i\] != ' ')
{
    break;
}
</code></pre>

<ul>
<li>  Formatted the curly braces <strong>{</strong> and <strong>}</strong> according to the best practices for the C# language.</li>
<li>  Put <strong>{</strong> and <strong>}</strong> after all conditionals and loops (when missing).</li>
<li>  Character casing: variables and fields made <strong>camelCase</strong>; types and methods made <strong>PascalCase</strong>.</li>
<li>  Formatted all other elements of the source code according to the best practices introduced in the course “<a href="http://telerikacademy.com/Courses/Courses/Details/244">High-Quality Programming Code</a>”.</li>
<li>  …</li>
</ul></li>
<li> Renamed variables:

<ul>
<li>  In class <code>Fifteen</code>: <code>number</code> to <code>numberOfMoves</code>.</li>
<li>  In <code>Main(string\[\] args)</code>: <code>g</code> to <code>gameFifteen</code>.</li>
</ul></li>
<li> Introduced constants:

<ul>
<li>  <code>GAME\_BOARD\_SIZE = 4</code></li>
<li>  <code>SCORE\_BOARD\_SIZE = 5</code>. </li>
</ul></li>
<li> Extracted the method <code>GenerateRandomGame()</code> from the method <code>Main()</code>.</li>
<li> Introduced class <code>ScoreBoard</code> and moved all related functionality in it.</li>
<li> Moved method <code>GenerateRandomNumber(int start, int end)</code> to separate class <code>RandomUtils</code>.</li>
<li> …</li>
</ol>
</article>
