/// <reference path="../JSBus/TransportInterfaces.ts" />
/// <reference path="../typings/jquery/jquery.d.ts" />
var JSBus;
(function (JSBus) {
    var SignalRSendTransport = (function () {
        function SignalRSendTransport(hub) {
            var _this = this;
            this.hub = hub;
            // Since SignalR is dependent on JQuery, it is ok to use
            // JQuery callbacks here.
            this.notifySentCallbacks = $.Callbacks();
            hub.start(function () {
                _this.ready = true;
            });
        }
        SignalRSendTransport.prototype.send = function (message) {
            console.log("Sending via SignalR", message);

            if (!this.ready) {
                throw new Error("SignalR hub is not ready for sending.");
            }

            // Consider using a separate web worker for data pump
            // Use own deferred instead of SignalR provided promise as
            // we need to supply the id to the caller for .then
            var deferred = $.Deferred();

            this.hub.server.execute(message).then(deferred.resolve(message.id)).then(this.notifySentCallbacks.fire(message)).fail(deferred.fail);

            return deferred.promise();
        };

        SignalRSendTransport.prototype.notifyWhenSent = function (callback) {
            this.notifySentCallbacks.add(callback);
        };
        return SignalRSendTransport;
    })();
    JSBus.SignalRSendTransport = SignalRSendTransport;
})(JSBus || (JSBus = {}));
