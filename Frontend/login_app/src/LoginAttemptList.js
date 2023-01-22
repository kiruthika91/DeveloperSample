import React, { useEffect, useState } from "react";
import "./LoginAttemptList.css";

const LoginAttempt = (props) => <li {...props}>{props.children}</li>;

const LoginAttemptList = (props) => {
	const [query,setQuery] = useState('');
	const [userList,setUserList] = useState([]);

	useEffect(() => {
		setUserList(props.attempts);
	},[props.attempts])

	const handleChange = (e) => {
		setQuery(e.target.value);
		const result = props.attempts.filter((user) => {
			if(e.target.value === ''){
				return user
			}
			return user?.toLowerCase()?.includes(e.target.value?.toLowerCase())
		})
		setUserList(result);
	}

	return(
	<div className="Attempt-List-Main">
	 	<p>Recent activity</p>
	  	<input type="input" placeholder="Filter..." value={query} onChange={handleChange}/>
		<ul className="Attempt-List">
			{userList.map((user) => (<LoginAttempt>{user}</LoginAttempt>) )}
		</ul>
	</div>
);}

export default LoginAttemptList;
