var ReactCSSTransitionGroup = React.addons.CSSTransitionGroup;

var ResultBox = React.createClass({
    render: function () {
        var html = [];
        if (this.props.data.length > 0) {
            html.push(
                <h1> Search results for {this.props.data} </h1>
            );
            document.getElementById('result').innerHTML = "search results for <span>" + this.props.data + "</span>";
        } 
       
            return (
                <div className="row">

                   

                </div>
            );
        
	}
});



		

window.ResultBox = ResultBox;
