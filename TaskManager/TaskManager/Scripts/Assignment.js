var AssignmentApp = angular.module('AssignmentApp', [])

AssignmentApp.controller('AssignmentController', function ($scope, AssignmentService) {

    getAssignments();
    function getAssignments() {
        AssignmentService.getAssignments()
            .success(function (studs) {
                $scope.Assignments = studs;
                console.log($scope.Assignments);
            })
            .error(function (error) {
                $scope.status = 'Unable to load customer data: ' + error.message;
                console.log($scope.status);
            });
    }
});


AssignmenApp.factory('AssignmentService', ['$http', function ($http) {

    var AssignmentService = {};
    AssignmentService.getAssignments = function () {
        return $http.get('/Assignment/index');
    };
    return AssignmentService;

}]);