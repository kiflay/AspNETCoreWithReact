var SearchBox = React.createClass({
	getInitialState: function() {
		return {term: ''};
	},
	handleTermChange: function(e) {
		this.setState({term: e.target.value});
	},
	handleSubmit: function(e) {
		e.preventDefault();
        var term = this.state.term;
        console.log(term);
		if (!term) {
			return;
		}
		this.props.onSearchSubmit({term: term});
		this.setState({term: ''});
	},
	render: function() {
		return (
            <form>
                <div className="row searchbox">
                    <div className="col-md-9"><input className="form-control" type="text" value={this.props.term} placeholder="Search" onChange={this.handleTermChange}/></div>
                    <div className="col-md-3"><a className="btn btn-default js-start" onClick={this.handleSubmit}><i className="glyphicon glyphicon-search"></i></a></div>
                </div>
			</form>
		);
	}
});

window.SearchBox = SearchBox;
