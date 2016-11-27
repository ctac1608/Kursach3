app.controller('searchPageController', function ($scope, $location, $routeParams, $http) {




    $scope.searchRow = $location.absUrl();
    console.log($scope.searchRow);

    $http.post("/Home/SearchResult/", $scope.searchRow).then(function () {

    });

});