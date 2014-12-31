var Greeters = (function () {
    function Greeters(greeting) {
        this.greeting = greeting;
    }
    Greeters.prototype.greet = function () {
        return "<h1>" + this.greeting + "</h1>";
    };
    return Greeters;
})();
;
var greeter = new Greeters("hello,world");
var str = greeter.greet();
document.body.innerHTML = str;
//# sourceMappingURL=greeter.js.map