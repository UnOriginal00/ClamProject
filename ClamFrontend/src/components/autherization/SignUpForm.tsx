import React from 'react'

type Props = {}

const SignUpForm = (props: Props) => {
  return (
    <form>

        <h2>Sign Up</h2>
        
        <input type="text" placeholder='Username' />
        <input type="email" placeholder='Email' />
        <input type="password" placeholder='Password' />
        <button type='submit'>Sign Up</button>

    </form>
  )
}

export default SignUpForm