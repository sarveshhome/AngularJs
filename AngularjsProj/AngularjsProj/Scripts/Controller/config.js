app.config(function ($httpProvider) {
    $httpProvider.defaults.headers.common = {};
    $httpProvider.defaults.headers.post = {};
    $httpProvider.defaults.headers.put = {};
    $httpProvider.defaults.headers.patch = {};
    $httpProvider.defaults.useXDomain = true;
    $httpProvider.defaults.timeout = 1000000; // 5min (5 min * 60 sec * 1000 millis)
    delete $httpProvider.defaults.headers.common["X-Requested-With"];
});