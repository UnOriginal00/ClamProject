import React from 'react'
import './AuthenticationFormStyleling.css'

type Props = {}

const LoginForm = (props: Props) => {
  return (
    <form className='form'>

        <h2>Login</h2>

        <input type="text" placeholder='Username' />
        <input type="password" placeholder='Password' />
        <button type='submit'>Login</button>

    </form>
  )
}

export default LoginForm;