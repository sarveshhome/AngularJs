app.controller('pageBindCtrl', ['$scope', '$rootScope', '$window', '$http', '$location', 'jsondataFactory', function ($scope, $rootScope, $window, $http, $location, jsondataFactory) {
    
    jsondataFactory.then(function (response) {       
        $scope.returnData =angular.fromJson(response.data);
    });
}]);
