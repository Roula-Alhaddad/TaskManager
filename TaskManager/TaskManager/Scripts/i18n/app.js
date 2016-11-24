//define a module
var app = angular.module('app', []);


//create a factory "AssignmentService" 
app.factory('AssignmentService', ['$http', function ($http) {

    var AssignmentService = {};
    AssignmentService.index = function () {
        return $http.get('/Assignment/index');
    };
    return AssignmentService;
}]);

//inject the values in the controller
app.controller('AssignmentController', function ($scope, AssignmentService) {
    $scope.Assignments = "";
    index();
    function index() {
        AssignmentService
            .success(function (studs) {
                $scope.Assignments=stud;
            })
            .error(function (error) {
                $scope.status = 'Unable to load customer data: ' + error.message;
            });
    }
});


