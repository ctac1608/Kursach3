app.controller("popularCreativeController", function ($scope, creativeService) {

    creativeService.getPopularCreatives($scope);

});



app.controller("newCreativeController", function ($scope, creativeService) {

    creativeService.getNewCreatives($scope);

});