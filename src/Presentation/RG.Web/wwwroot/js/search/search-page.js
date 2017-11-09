var TopBar = React.createClass({
	render: function() {
		return (
			<div className="row">
				<div className="col-md-12">
					<div className="col-md-10">
						<SearchBox
							onSearchSubmit={this.props.handleSearchSubmit}
							term={this.props.searchTerm}
						/>
					</div>

					
				</div>
			</div>
		);
	}
});

var SearchPage = React.createClass({
	getInitialState: function() {
	  return {
		data: [],
		searchTerm: null,
	  };
	},
	handleSearchSubmit: function(term) {
		
        console.log(term);
        console.log(term.term);
        var form = term.term;
        console.log(form);
		$.ajax({
			url: this.props.url,
			type: 'POST',
            data: JSON.stringify(form),
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
			success: function(data) {
				
                this.setState({ data: data });
                console.log(data);
			}.bind(this),
			error: function(xhr, status, err) {
				console.error(this.props.url, status, err.toString());
			}.bind(this)
        });
       
	},
	
	render: function() {
		return (
			<div>
				<TopBar
					handleSearchSubmit={this.handleSearchSubmit}
					searchTerm={this.state.searchTerm}

					
            />
                <ResultBox urlLink={this.props.urlLink} data={this.state.data} />
                
				</div>
			
		);
	}
});

window.SearchPage = SearchPage;
// export default SearchPage;
