class Greeters {
    constructor(public greeting: string) { }
    greet() {
        return "<h1>" + this.greeting + "</h1>";
    }
};
var greeter = new Greeters("hello,world");
var str = greeter.greet();
document.body.innerHTML = str;