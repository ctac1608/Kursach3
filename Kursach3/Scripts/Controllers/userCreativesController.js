app.controller("userCreativesController", function ($scope, $http, userPageService) {

    userPageService.getUserCreatives($scope);

    $scope.openCreative = function () {
        
    };

});