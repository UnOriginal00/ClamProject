import React from 'react'

type Props = {}

const LoginForm = (props: Props) => {
  return (
    <form>

        <h2>Login</h2>

        <input type="text" placeholder='Username' />
        <input type="password" placeholder='Password' />
        <button type='submit'>Login</button>

    </form>
  )
}

export default LoginForm