window.NLPProcessor.controller 'IndexController', ['$scope', '$http', ($scope, $http) ->
    console.log 'I am an index controller'
    $scope.submit = ->
        $http.get("/api/Token?word=#{$scope.inText}").success (data) ->
            console.log 'Got Data', data
            $scope.results = data
]