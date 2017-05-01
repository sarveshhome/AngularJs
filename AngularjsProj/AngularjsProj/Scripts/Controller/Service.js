app.factory('jsondataFactory', ['$http', function ($http) {
    return $http.get('test.json');
}]);