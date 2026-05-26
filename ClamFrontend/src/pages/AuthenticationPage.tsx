import React from 'react'
import {useState} from 'react'
import LoginForm from '../components/autherization/LoginForm'
import SignUpForm from '../components/autherization/SignUpForm'
import AuthenticationForm from '../components/autherization/AuthenticationForm'

type Props = {}

const AuthenticationPage = (props: Props) => {
  const [mode, setMode] = useState<'login' | 'signup'>('login');


  return (

    <div className='authentication-page'>

      <button onClick={() => setMode('login')}>Login</button>
      <button onClick={() => setMode('signup')}>SignUp</button>

      <AuthenticationForm>
      {mode === 'login' ? <LoginForm /> : <SignUpForm />}
      </AuthenticationForm>

    </div>

  )
}

export default AuthenticationPage;