var app = angular.module('myApp', ['ngRoute']);
app.controller('Test', function ($scope) {

        $scope.tester = "message displayed";

});

app.config(['$routeProvider', function ($routeProvider){
    $routeProvider.
        when('/routeOne', {
            template: '<p>Test</p>',
            controller: "Test"
        })
        .when('/routeTwo', {
            templateUrl: 'Views/Home/Index1.cshtml',
            controller: "Test"

        })

}]);