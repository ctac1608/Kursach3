app.controller('addController', function ($scope, $http) {
    $scope.modalShown = false;
    $scope.toggleModal = function () {
        $scope.modalShown = !$scope.modalShown;
    };
    $scope.hideModal = function () {
        $scope.modalShown = false;
    };

    $scope.creative = {
        Name: null 
    };

    $scope.chapter = {
        Name: null,
        Text: null
    };

    $scope.createCreative = function () {
        $http.post("/UserPage/Create/", $scope.creative, $scope.chapter).then(function () {});
    };

   
});