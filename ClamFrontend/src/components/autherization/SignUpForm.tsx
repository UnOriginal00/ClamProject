import React from 'react'
import './AuthenticationFormStyleling.css'

type Props = {}

const SignUpForm = (props: Props) => {
  return (
    <form className='form'>

        <h2>Sign Up</h2>
        
        <input type="text" placeholder='Username' />
        <input type="email" placeholder='Email' />
        <input type="password" placeholder='Password' />
        <button type='submit'>Sign Up</button>

    </form>
  )
}

export default SignUpForm;