# superSpy
Using Encapsulation to control access to class's methods and properties, with a simple SecretAgent style password portal. 

When you make all of your fields and methods public, any othert class can access them; Encapsulation lets you control what you share and what you keep private inside your class.

Super-spy Herb Jones is defending his nation as an undercover agent. His ciaAgent object is an instancer of the SecretAgent class.

Agent Jones has a plan to help him evade the enemy KGB agents. His AgentGreeting() method takes a password as a parameter. If he doesnt get the right password, he'll only receal his Alias (Dash). Seems like a foolproof plan, right? But what about the declaration of the RealName field...

Setting variables as public means they can be accessed, and changed from outside the class.

Agent Jones uses private fields to keep his identity a secret from enemy spy objects. Now, the only way to get to it is by calling the method that has access to the private parts of the class.

# Private fields and methods can only be access from inside the class. 
There's only one way that an object can get at the data stored inside another object's private fields: by using a public field or method to return the data. So while ciaAgents use the AgentGretting method, friendly spies can see everything - any class can see private fields in other instances of the same class.

